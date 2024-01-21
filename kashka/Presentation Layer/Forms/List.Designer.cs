namespace kashka.Presentation_Layer.Forms
{
    partial class List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstItems = new ListBox();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 32;
            lstItems.Location = new Point(17, 23);
            lstItems.Margin = new Padding(4, 5, 4, 5);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(427, 644);
            lstItems.TabIndex = 0;
            lstItems.DoubleClick += buttonOK_Click;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 686);
            Controls.Add(lstItems);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "List";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstItems;
    }
}