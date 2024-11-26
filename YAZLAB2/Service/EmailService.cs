﻿using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Yazlab_2.Models.Service
{
    public class EmailService
    {
        public async Task SendResetPasswordEmail(string toEmail, string resetLink)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, // TLS için doğru port
                Credentials = new NetworkCredential("sudeopan3@gmail.com", "Sudeopan.123"), // Gmail hesabınızın bilgileri
                EnableSsl = true // SSL/TLS bağlantısı aktif
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("your-email@gmail.com"), // Gönderen e-posta adresi
                Subject = "Şifre Sıfırlama Talebi",
                Body = $"Şifrenizi sıfırlamak için linke tıklayın: {resetLink}",
                IsBodyHtml = true // HTML içerik kullanıyorsanız true yapın
            };

            mailMessage.To.Add(toEmail); // Alıcı e-posta adresi

            try
            {
                await smtpClient.SendMailAsync(mailMessage); // E-posta gönder
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw;
            }
        }
    }

}