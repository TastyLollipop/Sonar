using System.Windows.Forms;

namespace Sonar
{
    public class MessageBoxData
    {
        //Store info of message boxes that might trigger

        public object[][] messageData = new object[][]
        {
            new object[]
            {
                "Error!",
                "Parameters are missing or invalid! Change them and try again",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            },

            new object[]
            {
                "Success!",
                "Operation Complete!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            },
        };
    }
}
