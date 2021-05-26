using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmailClassLibrary
{
    public class LogFile
    {

        public void WriteLogFile(string sender, string recipient, string subject, string messageBody, string emailStatus)
        {
            FileStream objFilestream = new FileStream(Path.Combine(Path.GetTempPath(), "Email Log"), FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
            
            objStreamWriter.WriteLine($"Date Sent: {DateTime.Now}");
            objStreamWriter.WriteLine($"Email Status: {emailStatus}");
            objStreamWriter.WriteLine($"To: {recipient}");
            objStreamWriter.WriteLine($"From: {sender}");
            objStreamWriter.WriteLine($"Subject: {subject}");
            objStreamWriter.WriteLine($"Message: {messageBody}");
            objStreamWriter.WriteLine(Environment.NewLine);
            
            objStreamWriter.Close();
            objFilestream.Close();
        }
    }
}
