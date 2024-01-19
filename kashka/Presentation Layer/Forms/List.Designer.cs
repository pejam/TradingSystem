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
            lstItems.ItemHeight = 21;
            lstItems.Location = new Point(12, 15);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(297, 424);
            lstItems.TabIndex = 0;
            lstItems.DoubleClick += buttonOK_Click;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 450);
            Controls.Add(lstItems);
            DoubleBuffered = true;
            Name = "List";
            RightToLeft = RightToLeft.Yes;
            Text = "List";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstItems;
    }
}