
namespace My_steck
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.show = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelShape = new System.Windows.Forms.Label();
            this.Shape = new System.Windows.Forms.TextBox();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.show.Location = new System.Drawing.Point(337, 302);
            this.show.Margin = new System.Windows.Forms.Padding(2);
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.Size = new System.Drawing.Size(92, 29);
            this.show.TabIndex = 19;
            this.show.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(337, 79);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(92, 50);
            this.Restart.TabIndex = 18;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelValue.Location = new System.Drawing.Point(14, 63);
            this.labelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(98, 24);
            this.labelValue.TabIndex = 17;
            this.labelValue.Text = "Значение";
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelShape.Location = new System.Drawing.Point(14, 22);
            this.labelShape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(132, 24);
            this.labelShape.TabIndex = 16;
            this.labelShape.Text = "Размер стека";
            // 
            // Shape
            // 
            this.Shape.AllowDrop = true;
            this.Shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Shape.Location = new System.Drawing.Point(146, 17);
            this.Shape.Margin = new System.Windows.Forms.Padding(2);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(143, 29);
            this.Shape.TabIndex = 15;
            this.Shape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPop
            // 
            this.buttonPop.Enabled = false;
            this.buttonPop.Location = new System.Drawing.Point(337, 191);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(92, 50);
            this.buttonPop.TabIndex = 14;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.Enabled = false;
            this.buttonTop.Location = new System.Drawing.Point(337, 247);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(92, 50);
            this.buttonTop.TabIndex = 13;
            this.buttonTop.Text = "Top";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Enabled = false;
            this.buttonPush.Location = new System.Drawing.Point(337, 135);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(92, 50);
            this.buttonPush.TabIndex = 12;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // Value
            // 
            this.Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Value.Enabled = false;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Value.Location = new System.Drawing.Point(146, 50);
            this.Value.Multiline = true;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(142, 38);
            this.Value.TabIndex = 11;
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // res
            // 
            this.res.FormattingEnabled = true;
            this.res.Location = new System.Drawing.Point(18, 96);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(271, 342);
            this.res.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelShape);
            this.Controls.Add(this.Shape);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.res);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox show;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.TextBox Shape;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.ListBox res;
    }
}

