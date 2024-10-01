
namespace DatabaseDoga
{
    partial class Form1
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
            this.ProductsListB = new System.Windows.Forms.ListBox();
            this.NameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuantityTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddItemB = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteItemB = new Guna.UI2.WinForms.Guna2Button();
            this.ReloadB = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ProductsListB
            // 
            this.ProductsListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductsListB.FormattingEnabled = true;
            this.ProductsListB.ItemHeight = 25;
            this.ProductsListB.Location = new System.Drawing.Point(12, 22);
            this.ProductsListB.Name = "ProductsListB";
            this.ProductsListB.Size = new System.Drawing.Size(267, 404);
            this.ProductsListB.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.Animated = true;
            this.NameTB.AutoRoundedCorners = true;
            this.NameTB.BorderRadius = 17;
            this.NameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTB.DefaultText = "";
            this.NameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTB.Location = new System.Drawing.Point(307, 69);
            this.NameTB.Name = "NameTB";
            this.NameTB.PasswordChar = '\0';
            this.NameTB.PlaceholderText = "Item name";
            this.NameTB.SelectedText = "";
            this.NameTB.Size = new System.Drawing.Size(209, 36);
            this.NameTB.TabIndex = 2;
            // 
            // QuantityTB
            // 
            this.QuantityTB.Animated = true;
            this.QuantityTB.AutoRoundedCorners = true;
            this.QuantityTB.BorderRadius = 17;
            this.QuantityTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTB.DefaultText = "";
            this.QuantityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTB.Location = new System.Drawing.Point(307, 124);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.PasswordChar = '\0';
            this.QuantityTB.PlaceholderText = "Item quantity";
            this.QuantityTB.SelectedText = "";
            this.QuantityTB.Size = new System.Drawing.Size(209, 36);
            this.QuantityTB.TabIndex = 3;
            // 
            // PriceTB
            // 
            this.PriceTB.Animated = true;
            this.PriceTB.AutoRoundedCorners = true;
            this.PriceTB.BorderRadius = 17;
            this.PriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTB.DefaultText = "";
            this.PriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTB.Location = new System.Drawing.Point(307, 181);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.PasswordChar = '\0';
            this.PriceTB.PlaceholderText = "item price";
            this.PriceTB.SelectedText = "";
            this.PriceTB.Size = new System.Drawing.Size(209, 36);
            this.PriceTB.TabIndex = 4;
            // 
            // AddItemB
            // 
            this.AddItemB.Animated = true;
            this.AddItemB.AutoRoundedCorners = true;
            this.AddItemB.BorderRadius = 21;
            this.AddItemB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddItemB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddItemB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddItemB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddItemB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddItemB.ForeColor = System.Drawing.Color.White;
            this.AddItemB.Location = new System.Drawing.Point(307, 241);
            this.AddItemB.Name = "AddItemB";
            this.AddItemB.Size = new System.Drawing.Size(91, 45);
            this.AddItemB.TabIndex = 5;
            this.AddItemB.Text = "Add item";
            // 
            // DeleteItemB
            // 
            this.DeleteItemB.Animated = true;
            this.DeleteItemB.AutoRoundedCorners = true;
            this.DeleteItemB.BorderRadius = 21;
            this.DeleteItemB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteItemB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteItemB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteItemB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteItemB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteItemB.ForeColor = System.Drawing.Color.White;
            this.DeleteItemB.Location = new System.Drawing.Point(425, 241);
            this.DeleteItemB.Name = "DeleteItemB";
            this.DeleteItemB.Size = new System.Drawing.Size(91, 45);
            this.DeleteItemB.TabIndex = 6;
            this.DeleteItemB.Text = "Delete item";
            // 
            // ReloadB
            // 
            this.ReloadB.Animated = true;
            this.ReloadB.AutoRoundedCorners = true;
            this.ReloadB.BorderRadius = 21;
            this.ReloadB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReloadB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReloadB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReloadB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReloadB.ForeColor = System.Drawing.Color.White;
            this.ReloadB.Location = new System.Drawing.Point(307, 384);
            this.ReloadB.Name = "ReloadB";
            this.ReloadB.Size = new System.Drawing.Size(209, 45);
            this.ReloadB.TabIndex = 7;
            this.ReloadB.Text = "Reload Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.ReloadB);
            this.Controls.Add(this.DeleteItemB);
            this.Controls.Add(this.AddItemB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.ProductsListB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ProductsListB;
        private Guna.UI2.WinForms.Guna2TextBox NameTB;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTB;
        private Guna.UI2.WinForms.Guna2TextBox PriceTB;
        private Guna.UI2.WinForms.Guna2Button AddItemB;
        private Guna.UI2.WinForms.Guna2Button DeleteItemB;
        private Guna.UI2.WinForms.Guna2Button ReloadB;
    }
}

