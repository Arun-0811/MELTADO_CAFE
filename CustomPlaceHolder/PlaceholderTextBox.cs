using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MELTADO_CAFE.CustomPlaceHolder
{
    public class PlaceholderTextBox : TextBox
    {
        private string _placeholderText;
        private bool _isPlaceholderActive;

        public string PlaceholderText
        {
            get => _placeholderText;
            set { _placeholderText = value; SetPlaceholder(); }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetPlaceholder();
            this.Enter += RemovePlaceholder;
            this.Leave += SetPlaceholder;
        }

        private void SetPlaceholder(object sender = null, EventArgs e = null)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                _isPlaceholderActive = true;
                this.Text = _placeholderText;
                this.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (_isPlaceholderActive)
            {
                this.Text = "";
                this.ForeColor = Color.Black;
                _isPlaceholderActive = false;
            }
        }

        public bool IsPlaceholderActive => _isPlaceholderActive;
    }

}
