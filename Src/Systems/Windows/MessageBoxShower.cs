using System.Windows.Forms;

namespace Sudocu.Src.Systems.Windows.Forms
{
    public static class MessageBoxShower
    {
        private const string ERROR       = "Error";
        private const string WARNING     = "Warning";
        private const string INFORMATION = "Information";
        
        private const string QUESTION = "Question";
        
        public static DialogResult ShowErrorMessage ( string message )
        {
            return ShowErrorMessage( ERROR, message );
        }
        
        public static DialogResult ShowErrorMessage ( string title, string message )
        {
            return MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
        
        public static DialogResult ShowWarningMessage ( string message )
        {
            return ShowWarningMessage( WARNING, message );
        }
        
        public static DialogResult ShowWarningMessage ( string title, string message )
        {
            return MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning );
        }
        
        public static DialogResult ShowInformationMessage ( string message )
        {
            return ShowInformationMessage( INFORMATION, message );
        }
        
        public static DialogResult ShowInformationMessage ( string title, string message )
        {
            return MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
        
        public static DialogResult ShowQuestionMessage ( string message )
        {
            return ShowQuestionMessage( QUESTION, message );
        }
        
        public static DialogResult ShowQuestionMessage ( string title, string message )
        {
            return MessageBox.Show( message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question );
        }
        
        public static DialogResult ShowCancelQuestionMessage ( string message )
        {
            return ShowCancelQuestionMessage( QUESTION, message );
        }
        
        public static DialogResult ShowCancelQuestionMessage ( string title, string message )
        {
            return MessageBox.Show( message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
        }
    }
}