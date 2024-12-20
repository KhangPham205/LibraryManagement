using LibraryManagementApplication.Model.Class;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel
{
    public class RecoverViewModel : BaseViewModel
    {
        public string email { get; set; }
        public string sdt { get; set; }
        public string cccd { get; set; }

        public ICommand RecoverCommand { get; set; }

        public RecoverViewModel()
        {
            RecoverCommand = new RelayCommand<object>((p) => true, (p) =>
            {
                recover();
            });
        }

        public void recover()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    // Tìm tài khoản có thông tin khớp với email, số điện thoại và CCCD
                    var taiKhoan = context.TaiKhoans.FirstOrDefault(tk => tk.Email == email && tk.SDT == sdt && tk.CCCD == cccd);

                    if (taiKhoan != null)
                    {
                        // Gửi email chứa mật khẩu
                        SendEmail(taiKhoan.Email, taiKhoan.Password);
                        EXMessagebox.Show("Mật khẩu đã được gửi qua email của bạn!", "Thông báo");
                    }
                    else
                    {
                        // Nếu không tìm thấy tài khoản, hiển thị thông báo lỗi
                        EXMessagebox.Show("Không tìm thấy tài khoản với thông tin đã cung cấp!", "Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi trong quá trình tương tác với cơ sở dữ liệu hoặc gửi email
                EXMessagebox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void SendEmail(string recipientEmail, string password)
        {
            try
            {
                // Thông tin tài khoản Gmail
                string senderEmail = "khonggian2k0520@gmail.com";
                string senderPassword = "ttcs ttwh psdn izyw"; // Thay bằng App Password nếu đã tạo

                // Nội dung email
                string subject = "Khôi phục mật khẩu";
                string body = $"Xin chào,\n\nMật khẩu của bạn là: {password}\n\nCảm ơn bạn đã sử dụng hệ thống của chúng tôi!";

                // Cấu hình SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                // Tạo email
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false // Gửi dạng text
                };
                mail.To.Add(recipientEmail);

                // Gửi email
                smtpClient.Send(mail);
                Console.WriteLine("Email đã được gửi thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi email: {ex.Message}");
            }
        }
    }
}