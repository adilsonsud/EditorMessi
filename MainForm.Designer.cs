/*
 * Criado por SharpDevelop.
 * Usuário: Adilson
 * Data: 24/11/2021
 * Hora: 23:07
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace EditorMessi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Rtext = new System.Windows.Forms.RichTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bt3 = new System.Windows.Forms.Button();
			this.bt2 = new System.Windows.Forms.Button();
			this.bt1 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Rtext02 = new System.Windows.Forms.RichTextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.Rtext);
			this.panel1.Location = new System.Drawing.Point(12, 65);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 290);
			this.panel1.TabIndex = 0;
			// 
			// Rtext
			// 
			this.Rtext.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Rtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rtext.Location = new System.Drawing.Point(0, 0);
			this.Rtext.Name = "Rtext";
			this.Rtext.Size = new System.Drawing.Size(668, 288);
			this.Rtext.TabIndex = 0;
			this.Rtext.Text = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.bt3);
			this.panel2.Controls.Add(this.bt2);
			this.panel2.Controls.Add(this.bt1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(693, 59);
			this.panel2.TabIndex = 1;
			// 
			// bt3
			// 
			this.bt3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt3.Location = new System.Drawing.Point(226, 21);
			this.bt3.Name = "bt3";
			this.bt3.Size = new System.Drawing.Size(87, 35);
			this.bt3.TabIndex = 2;
			this.bt3.Text = "Limpar";
			this.bt3.UseVisualStyleBackColor = true;
			this.bt3.Click += new System.EventHandler(this.Bt3Click);
			// 
			// bt2
			// 
			this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt2.Location = new System.Drawing.Point(119, 21);
			this.bt2.Name = "bt2";
			this.bt2.Size = new System.Drawing.Size(87, 35);
			this.bt2.TabIndex = 1;
			this.bt2.Text = "Copiar";
			this.bt2.UseVisualStyleBackColor = true;
			this.bt2.Click += new System.EventHandler(this.Bt2Click);
			// 
			// bt1
			// 
			this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt1.Location = new System.Drawing.Point(13, 21);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(87, 35);
			this.bt1.TabIndex = 0;
			this.bt1.Text = "Separar";
			this.toolTip1.SetToolTip(this.bt1, "Se vc Queima a Rosca Clique aki");
			this.bt1.UseVisualStyleBackColor = true;
			this.bt1.Click += new System.EventHandler(this.Bt1Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.Rtext02);
			this.panel3.Location = new System.Drawing.Point(10, 360);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(670, 290);
			this.panel3.TabIndex = 2;
			// 
			// Rtext02
			// 
			this.Rtext02.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Rtext02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rtext02.Location = new System.Drawing.Point(0, 0);
			this.Rtext02.Name = "Rtext02";
			this.Rtext02.Size = new System.Drawing.Size(668, 288);
			this.Rtext02.TabIndex = 0;
			this.Rtext02.Text = "";
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.BackColor = System.Drawing.Color.Moccasin;
			this.toolTip1.InitialDelay = 100;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ReshowDelay = 100;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(693, 668);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "EditorMessi";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button bt3;
		private System.Windows.Forms.RichTextBox Rtext02;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button bt1;
		private System.Windows.Forms.Button bt2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RichTextBox Rtext;
		private System.Windows.Forms.Panel panel1;
	}
}
