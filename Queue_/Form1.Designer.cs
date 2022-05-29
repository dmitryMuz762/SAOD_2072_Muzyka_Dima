
namespace Queue_
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
            this.button_clean = new System.Windows.Forms.Button();
            this.label_stack = new System.Windows.Forms.Label();
            this.button_toarray = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_top = new System.Windows.Forms.Button();
            this.button_pop = new System.Windows.Forms.Button();
            this.button_push = new System.Windows.Forms.Button();
            this.button_count = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_clean
            // 
            this.button_clean.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_clean.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.Location = new System.Drawing.Point(373, 213);
            this.button_clean.Margin = new System.Windows.Forms.Padding(2);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(116, 45);
            this.button_clean.TabIndex = 20;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = false;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label_stack
            // 
            this.label_stack.AutoSize = true;
            this.label_stack.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stack.Location = new System.Drawing.Point(58, 282);
            this.label_stack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stack.Name = "label_stack";
            this.label_stack.Size = new System.Drawing.Size(0, 37);
            this.label_stack.TabIndex = 19;
            // 
            // button_toarray
            // 
            this.button_toarray.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_toarray.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_toarray.Location = new System.Drawing.Point(51, 126);
            this.button_toarray.Margin = new System.Windows.Forms.Padding(2);
            this.button_toarray.Name = "button_toarray";
            this.button_toarray.Size = new System.Drawing.Size(140, 46);
            this.button_toarray.TabIndex = 18;
            this.button_toarray.Text = "ToArray";
            this.button_toarray.UseVisualStyleBackColor = false;
            this.button_toarray.Click += new System.EventHandler(this.button_toarray_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.Location = new System.Drawing.Point(51, 11);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(190, 88);
            this.textBox_input.TabIndex = 17;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_top
            // 
            this.button_top.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_top.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_top.Location = new System.Drawing.Point(373, 144);
            this.button_top.Margin = new System.Windows.Forms.Padding(2);
            this.button_top.Name = "button_top";
            this.button_top.Size = new System.Drawing.Size(116, 46);
            this.button_top.TabIndex = 16;
            this.button_top.Text = "Top";
            this.button_top.UseVisualStyleBackColor = false;
            this.button_top.Click += new System.EventHandler(this.button_top_Click);
            // 
            // button_pop
            // 
            this.button_pop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_pop.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pop.Location = new System.Drawing.Point(373, 82);
            this.button_pop.Margin = new System.Windows.Forms.Padding(2);
            this.button_pop.Name = "button_pop";
            this.button_pop.Size = new System.Drawing.Size(116, 46);
            this.button_pop.TabIndex = 15;
            this.button_pop.Text = "Pop";
            this.button_pop.UseVisualStyleBackColor = false;
            this.button_pop.Click += new System.EventHandler(this.button_pop_Click);
            // 
            // button_push
            // 
            this.button_push.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_push.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_push.Location = new System.Drawing.Point(373, 20);
            this.button_push.Margin = new System.Windows.Forms.Padding(2);
            this.button_push.Name = "button_push";
            this.button_push.Size = new System.Drawing.Size(116, 46);
            this.button_push.TabIndex = 14;
            this.button_push.Text = "Push";
            this.button_push.UseVisualStyleBackColor = false;
            this.button_push.Click += new System.EventHandler(this.button_push_Click);
            // 
            // button_count
            // 
            this.button_count.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_count.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_count.Location = new System.Drawing.Point(218, 127);
            this.button_count.Margin = new System.Windows.Forms.Padding(2);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(116, 45);
            this.button_count.TabIndex = 21;
            this.button_count.Text = "Count";
            this.button_count.UseVisualStyleBackColor = false;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(278, 11);
            this.size.Margin = new System.Windows.Forms.Padding(2);
            this.size.Multiline = true;
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(56, 88);
            this.size.TabIndex = 22;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 371);
            this.Controls.Add(this.size);
            this.Controls.Add(this.button_count);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.label_stack);
            this.Controls.Add(this.button_toarray);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_top);
            this.Controls.Add(this.button_pop);
            this.Controls.Add(this.button_push);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label_stack;
        private System.Windows.Forms.Button button_toarray;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_top;
        private System.Windows.Forms.Button button_pop;
        private System.Windows.Forms.Button button_push;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.TextBox size;
    }
}

