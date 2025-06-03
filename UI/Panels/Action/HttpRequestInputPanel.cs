using MobiFlight.InputConfig;
using MobiFlight.UI.Panels.Config;
using System;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels.Action
{
    public partial class HttpRequestInputPanel : UserControl, IPanelConfigSync
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public HttpRequestInputPanel()
        {
            InitializeComponent();
        }

        public void syncFromConfig(object config)
        {
            HttpInputAction httpRequestAction = config as HttpInputAction;
            if (httpRequestAction == null) return;

            UrlText.Text = httpRequestAction.Url.ToString();
        }

        public InputAction ToConfig()
        {
            HttpInputAction inputAction = new HttpInputAction
            {
                Url = new Uri(UrlText.Text),
            };

            return inputAction;
        }

        private void UrlText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null || !textBox.Visible) return;

            var contents = textBox.Text;

            if (!Uri.TryCreate(contents, UriKind.Absolute, out _))
            {
                Log.Instance.log($"URL parsing problem: {contents}", LogSeverity.Error);
                displayError(
                    sender as Control,
                    i18n._tr("uiMessageValidationMustBeUrl")
                );
            }
        }

        private void displayError(Control control, String message)
        {
            errorProvider.SetIconAlignment(control, ErrorIconAlignment.TopRight);
            errorProvider.SetError(
                    control,
                    message);
            MessageBox.Show(message, i18n._tr("Hint"));
        }
    }
}
