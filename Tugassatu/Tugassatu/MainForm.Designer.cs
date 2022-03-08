/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 01/03/2022
 * Time: 8:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugassatu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btntambah;
		private System.Windows.Forms.ListBox list;
		private System.Windows.Forms.Button btnhapus;
		private System.Windows.Forms.TextBox txtbox;
		private System.Windows.Forms.Label word;
		private System.Windows.Forms.Button btnnama;
		private System.Windows.Forms.TextBox txtnama;
		private System.Windows.Forms.TextBox txtnim;
		private System.Windows.Forms.TextBox txtkelas;
		private System.Windows.Forms.Button btnnim;
		private System.Windows.Forms.Button btnkelas;
		private System.Windows.Forms.Label nama;
		private System.Windows.Forms.Label nim;
		private System.Windows.Forms.Label kelas;
		
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
			this.btntambah = new System.Windows.Forms.Button();
			this.list = new System.Windows.Forms.ListBox();
			this.btnhapus = new System.Windows.Forms.Button();
			this.txtbox = new System.Windows.Forms.TextBox();
			this.word = new System.Windows.Forms.Label();
			this.btnkelas = new System.Windows.Forms.Button();
			this.nama = new System.Windows.Forms.Label();
			this.nim = new System.Windows.Forms.Label();
			this.txtnama = new System.Windows.Forms.TextBox();
			this.txtnim = new System.Windows.Forms.TextBox();
			this.kelas = new System.Windows.Forms.Label();
			this.txtkelas = new System.Windows.Forms.TextBox();
			this.btnnim = new System.Windows.Forms.Button();
			this.btnnama = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btntambah
			// 
			this.btntambah.BackColor = System.Drawing.Color.Black;
			this.btntambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btntambah.Location = new System.Drawing.Point(235, 253);
			this.btntambah.Name = "btntambah";
			this.btntambah.Size = new System.Drawing.Size(105, 32);
			this.btntambah.TabIndex = 1;
			this.btntambah.Text = "Tambah";
			this.btntambah.UseVisualStyleBackColor = false;
			this.btntambah.Click += new System.EventHandler(this.BtntambahClick);
			// 
			// list
			// 
			this.list.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.list.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.list.FormattingEnabled = true;
			this.list.ItemHeight = 22;
			this.list.Location = new System.Drawing.Point(12, 192);
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(217, 136);
			this.list.TabIndex = 3;
			this.list.SelectedIndexChanged += new System.EventHandler(this.ListSelectedIndexChanged);
			// 
			// btnhapus
			// 
			this.btnhapus.BackColor = System.Drawing.Color.Black;
			this.btnhapus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnhapus.Location = new System.Drawing.Point(235, 291);
			this.btnhapus.Name = "btnhapus";
			this.btnhapus.Size = new System.Drawing.Size(105, 33);
			this.btnhapus.TabIndex = 3;
			this.btnhapus.Text = "Hapus";
			this.btnhapus.UseVisualStyleBackColor = false;
			this.btnhapus.Click += new System.EventHandler(this.BtnhapusClick);
			// 
			// txtbox
			// 
			this.txtbox.BackColor = System.Drawing.Color.White;
			this.txtbox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbox.Location = new System.Drawing.Point(12, 163);
			this.txtbox.Multiline = true;
			this.txtbox.Name = "txtbox";
			this.txtbox.Size = new System.Drawing.Size(328, 23);
			this.txtbox.TabIndex = 5;
			// 
			// word
			// 
			this.word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.word.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.word.ForeColor = System.Drawing.SystemColors.ControlText;
			this.word.Location = new System.Drawing.Point(248, 201);
			this.word.Name = "word";
			this.word.Size = new System.Drawing.Size(66, 49);
			this.word.TabIndex = 0;
			this.word.Text = "List Barang";
			this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnkelas
			// 
			this.btnkelas.Location = new System.Drawing.Point(248, 101);
			this.btnkelas.Name = "btnkelas";
			this.btnkelas.Size = new System.Drawing.Size(78, 21);
			this.btnkelas.TabIndex = 11;
			this.btnkelas.Text = "Tampilkan";
			this.btnkelas.UseVisualStyleBackColor = true;
			this.btnkelas.Click += new System.EventHandler(this.BtnkelasClick);
			// 
			// nama
			// 
			this.nama.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nama.Location = new System.Drawing.Point(23, 37);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(100, 23);
			this.nama.TabIndex = 12;
			this.nama.Text = "Nama";
			// 
			// nim
			// 
			this.nim.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nim.Location = new System.Drawing.Point(23, 67);
			this.nim.Name = "nim";
			this.nim.Size = new System.Drawing.Size(100, 23);
			this.nim.TabIndex = 13;
			this.nim.Text = "Nim";
			// 
			// txtnama
			// 
			this.txtnama.BackColor = System.Drawing.Color.White;
			this.txtnama.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnama.Location = new System.Drawing.Point(80, 37);
			this.txtnama.Multiline = true;
			this.txtnama.Name = "txtnama";
			this.txtnama.Size = new System.Drawing.Size(162, 21);
			this.txtnama.TabIndex = 14;
			// 
			// txtnim
			// 
			this.txtnim.BackColor = System.Drawing.Color.White;
			this.txtnim.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnim.Location = new System.Drawing.Point(80, 69);
			this.txtnim.Multiline = true;
			this.txtnim.Name = "txtnim";
			this.txtnim.Size = new System.Drawing.Size(162, 21);
			this.txtnim.TabIndex = 15;
			// 
			// kelas
			// 
			this.kelas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kelas.Location = new System.Drawing.Point(23, 101);
			this.kelas.Name = "kelas";
			this.kelas.Size = new System.Drawing.Size(100, 23);
			this.kelas.TabIndex = 16;
			this.kelas.Text = "Kelas";
			// 
			// txtkelas
			// 
			this.txtkelas.BackColor = System.Drawing.Color.White;
			this.txtkelas.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtkelas.Location = new System.Drawing.Point(80, 101);
			this.txtkelas.Multiline = true;
			this.txtkelas.Name = "txtkelas";
			this.txtkelas.Size = new System.Drawing.Size(162, 21);
			this.txtkelas.TabIndex = 17;
			// 
			// btnnim
			// 
			this.btnnim.Location = new System.Drawing.Point(248, 67);
			this.btnnim.Name = "btnnim";
			this.btnnim.Size = new System.Drawing.Size(78, 21);
			this.btnnim.TabIndex = 18;
			this.btnnim.Text = "Tampilkan";
			this.btnnim.UseVisualStyleBackColor = true;
			this.btnnim.Click += new System.EventHandler(this.BtnnimClick);
			// 
			// btnnama
			// 
			this.btnnama.Location = new System.Drawing.Point(248, 37);
			this.btnnama.Name = "btnnama";
			this.btnnama.Size = new System.Drawing.Size(78, 21);
			this.btnnama.TabIndex = 19;
			this.btnnama.Text = "Tampilkan";
			this.btnnama.UseVisualStyleBackColor = true;
			this.btnnama.Click += new System.EventHandler(this.BtnnamaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(377, 350);
			this.Controls.Add(this.btnnama);
			this.Controls.Add(this.btnnim);
			this.Controls.Add(this.txtkelas);
			this.Controls.Add(this.kelas);
			this.Controls.Add(this.txtnim);
			this.Controls.Add(this.txtnama);
			this.Controls.Add(this.nim);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.btnkelas);
			this.Controls.Add(this.txtbox);
			this.Controls.Add(this.btnhapus);
			this.Controls.Add(this.list);
			this.Controls.Add(this.btntambah);
			this.Controls.Add(this.word);
			this.Name = "MainForm";
			this.Text = "Tugassatu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
