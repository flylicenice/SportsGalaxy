using Microsoft.EntityFrameworkCore.Query.Internal;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace SportsGalaxy
{
    public partial class EventBlockHori : UserControl
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        string matricNo, eventName, eventLocation, eventDate, eventTime, userEmail;
        int eventId;

        public EventBlockHori(string matricNo)
        {
            InitializeComponent();
            this.matricNo = matricNo;
        }

        private void ticketBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to generate ticket?",
                "Generate Ticket",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                Random rand = new Random();
                string uniqueTicketCode = $"SG-{matricNo}-{eventId}-{rand.Next(1000, 9999)}";

                string insertQuery = @"INSERT INTO [TICKET] (matric_no, eventId, ticket_code) VALUES (@matricNo, @eventId, @ticketCode)";
                string selectQuery = @"SELECT email FROM [USER] WHERE matric_no = @matricNo";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@matricNo", matricNo);
                        cmd.Parameters.AddWithValue("@eventId", eventId);
                        cmd.Parameters.AddWithValue("@ticketCode", uniqueTicketCode);

                        try
                        {
                            conn.Open();
                            int insertRow = cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.Message);
                            return;
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@matricNo", matricNo);

                        try
                        {
                            conn.Open();
                            userEmail = cmd.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex.Message);
                            return;
                        }
                    }
                }

                try
                {
                    Bitmap qrCodeImage = GenerateQRBitmap(uniqueTicketCode);

                    string directoryPath = Path.Combine(Path.GetTempPath(), "SportsGalaxyTickets");
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    string tempImagePath = Path.Combine(directoryPath, $"Ticket_{uniqueTicketCode}.png");
                    qrCodeImage.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Png);
                    SendEmailWithQR(userEmail, uniqueTicketCode, tempImagePath);

                    if (File.Exists(tempImagePath)) { File.Delete(tempImagePath); }

                    MessageBox.Show("Ticket sent to email.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Booking saved, but email got a problem: " + ex.Message, "Email Alert");
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to cancel joining the event?",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM [JOIN_EVENTS] WHERE matric_no = @matricNo AND eventId = @eventId";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@matricNo", matricNo);
                        cmd.Parameters.AddWithValue("@eventId", eventId);

                        try
                        {
                            conn.Open();
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Unjoin successfully!");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unjoin failed.");
                            return;
                        }
                    }
                }
            }
        }

        public void FillData(int eventId, string name, string location, string date, string time)
        {
            nameLbl.Text = name;
            locationLbl.Text = location;
            dateLbl.Text = date;
            timeLbl.Text = time;


            //To fix issue by converting date string into clean date-only format
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                dateLbl.Text = parsedDate.ToString("d/M/yyyy"); 
            }
            else
            {
                dateLbl.Text = date; 
            }

            this.eventId = eventId;
            this.eventName = name;
            this.eventLocation = location;
            this.eventDate = date;
            this.eventTime = time;
            
        }

        private Bitmap GenerateQRBitmap(string dataText)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(dataText, QRCodeGenerator.ECCLevel.Q))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                return qrCode.GetGraphic(20);
            }
        }

        private void SendEmailWithQR(string recipientEmail, string ticketCode, string imagePath)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("sportsgalaxy74@gmail.com", "SportsGalaxy UTeM");
                mail.To.Add(recipientEmail);
                mail.Subject = "Your SportsGalaxy Event Pass / QR Confirmation";

                Attachment qrAttachment = new Attachment(imagePath);
                qrAttachment.ContentId = "QRCodeImage";
                mail.Attachments.Add(qrAttachment);

                mail.Body = $@"
                <div style='font-family: Arial, sans-serif; border: 1px solid #ddd; padding: 20px; border-radius: 10px; max-width: 500px;'>
                    <h2 style='color: #2E7D32;'>Registration Confirmed!</h2>
                    <p>Thank you for using SportsGalaxy.</p>
                    <hr style='border: 0; border-top: 1px solid #eee;' />
                    <p><strong>Ticket Reference:</strong> {ticketCode}</p>
                    <p style='font-size: 12px; color: #777;'>Please do not share this QR code with anyone else.</p>
                </div>";

                mail.IsBodyHtml = true;

                using (SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"))
                {
                    smtpServer.Port = 587;
                    smtpServer.Credentials = new NetworkCredential("sportsgalaxy74@gmail.com", "skvr zfme fsug cpac");
                    smtpServer.EnableSsl = true;

                    smtpServer.Send(mail);
                }
            }
        }
    }
}
