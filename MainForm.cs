/*
 * Criado por SharpDevelop.
 * Usuário: Adilson
 * Data: 24/11/2021
 * Hora: 23:07
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EditorMessi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		
		
		public MainForm()
		{
			InitializeComponent();		
		}
		
		void Bt1Click(object sender, EventArgs e)
		{
			
			string texto = Rtext.Text;
			string[] texto2 = texto.Split(';');
			
			for (int i = 0; i < texto2.Length; i++)
			{
				string t = texto2[i];
				Rtext02.AppendText(System.Environment.NewLine + t + ";");
					
			}
			
				
			
			
		}
		
		void Bt3Click(object sender, EventArgs e)
		{
			Rtext.Clear();
			Rtext02.Clear();
		}
		
		
		void Bt2Click(object sender, EventArgs e)
		{
			
			Clipboard.SetText(Rtext02.Text);
		}
	}
}
