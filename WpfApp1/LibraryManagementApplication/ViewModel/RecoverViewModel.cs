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
                string subject = "Thông báo khôi phục mật khẩu tài khoản";
                string body = $@"
Kính gửi Quý độc giả,

Chúng tôi đã nhận được yêu cầu khôi phục mật khẩu từ Quý độc giả cho tài khoản của mình trên hệ thống quản lý thư viện.

Dưới đây là thông tin mật khẩu của Quý độc giả:
--------------------------------------------------
Mật khẩu: {password}
--------------------------------------------------

Vui lòng sử dụng mật khẩu này để đăng nhập vào hệ thống. Chúng tôi khuyến nghị Quý độc giả đổi mật khẩu sau khi đăng nhập để đảm bảo an toàn thông tin tài khoản.

Nếu Quý độc giả không yêu cầu khôi phục mật khẩu, vui lòng bỏ qua email này hoặc liên hệ ngay với chúng tôi qua email hỗ trợ: khonggian2k0520@gmail.com để được hỗ trợ kịp thời.

Chân thành cảm ơn Quý độc giả đã tin tưởng và sử dụng dịch vụ của chúng tôi.

Trân trọng,
Đội ngũ hỗ trợ
Thư viện điện tử LibraryService
Email: khonggian2k0520@gmail.com
Điện thoại: 0123 456 789
";


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