using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace app_pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            BaseFont timesRoman = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f_15_bold = new iTextSharp.text.Font(timesRoman, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_15_normal = new iTextSharp.text.Font(timesRoman, 12, iTextSharp.text.Font.NORMAL);

            Random rnd = new Random();
            int name = rnd.Next(1, 1000);
            //String sDate = DateTime.Now.ToString();
            //DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            //String dy = datevalue.Day.ToString();
            //String mn = datevalue.Month.ToString();
            //String yy = datevalue.Year.ToString();
            FileStream os = new FileStream(path + "\\Ma\'lumotnoma_" + name.ToString() + ".pdf", FileMode.Create);

            using (os)
            {
                PdfWriter.GetInstance(doc, os);
                doc.Open();

                Checker();

                // first table

                PdfPTable table1 = new PdfPTable(2);
                float[] width = new float[] { 25f, 75f };
                table1.SetWidths(width);

                PdfPCell cel1 = new PdfPCell(new Phrase("O\'ZBEKISTON", f_15_bold));
                PdfPCell row1 = new PdfPCell(new Phrase("26-shakl", f_15_normal));
                PdfPCell cel2 = new PdfPCell(new Phrase("RESPUBLIKASI", f_15_bold));
                PdfPCell row2 = new PdfPCell(new Phrase("MA\'LUMOTNOMA", f_15_bold));
                PdfPCell cel3 = new PdfPCell(new Phrase("TRANSPORT", f_15_bold));
                PdfPCell row3 = new PdfPCell(new Phrase("Berildi   " + textBox2.Text + "   yilda tug’ilgan talaba", f_15_normal));
                PdfPCell cel4 = new PdfPCell(new Phrase("VAZIRLIGI", f_15_bold));
                PdfPCell row4 = new PdfPCell(new Phrase(textBox3.Text, f_15_normal));
                PdfPCell cel5 = new PdfPCell(new Phrase("TOSHKENT DAVLAT", f_15_bold));
                PdfPCell row5 = new PdfPCell(new Phrase("" + textBox4.Text[6] + textBox4.Text[7] + textBox4.Text[8] + textBox4.Text[9] + " yil " + textBox4.Text[3] + textBox4.Text[4] + " “ " + textBox4.Text[0] + textBox4.Text[1] + " ”  kundagi  " + textBox5.Text + "  sonli buyruq asosida Toshkent Davlat", f_15_normal));
                PdfPCell cel6 = new PdfPCell(new Phrase("TRANSPORT", f_15_bold));
                PdfPCell row6 = new PdfPCell(new Phrase("Transport Universitetiga o\'qishga qabul qilindi va hozirgi kunda  " + textBox6.Text + "  bosqich ", f_15_normal));
                PdfPCell cel7 = new PdfPCell(new Phrase("UNIVERSITETI", f_15_bold));
                PdfPCell row7 = new PdfPCell(new Phrase("talabasi hisoblanadi. O\'qish davri  " + textBox7.Text + "  gacha davom etadi.", f_15_normal));
                PdfPCell cel8 = new PdfPCell(new Phrase("100167, Toshkent shahar,", f_15_bold));
                PdfPCell row8 = new PdfPCell(new Phrase("Ushbu ma\'lumot  " + textBox8.Text, f_15_normal));
                PdfPCell cel9 = new PdfPCell(new Phrase("Odilxo\'jaev ko\'chasi, 1", f_15_bold));
                PdfPCell row9 = new PdfPCell(new Phrase("Mudofaa ishlari bo\'limiga taqdim etish uchun berildi.", f_15_normal));
                PdfPCell cel10 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell row10 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell cel11 = new PdfPCell(new Phrase("No:   " + textBox1.Text, f_15_bold));
                PdfPCell row11 = new PdfPCell(new Phrase("  ", f_15_normal));

                PdfPCell acel1 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell arow1 = new PdfPCell(new Phrase("   ", f_15_bold));

                PdfPCell acel11 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell arow11 = new PdfPCell(new Phrase("   ", f_15_bold));

                PdfPCell cel12 = new PdfPCell(new Phrase("“" + textBox9.Text[0] + textBox9.Text[1] + "”-" + textBox9.Text[3] + textBox9.Text[4] + "-" + textBox9.Text[6] + textBox9.Text[7] + textBox9.Text[8] + textBox9.Text[9] + " ", f_15_bold));
                PdfPCell row12 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell cel13 = new PdfPCell(new Phrase("Telefon (71) 299-02-98", f_15_bold));
                PdfPCell row13 = new PdfPCell(new Phrase("             O\'quv ishlari bo\'yicha prorektor                               " + textBox28.Text, f_15_bold));
                PdfPCell cel14 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell row14 = new PdfPCell(new Phrase("             2-Bo\'lim boshlig\'i                                                     Sh.T.Shoxidayeva", f_15_bold));

                cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel11.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel12.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel13.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel14.Border = iTextSharp.text.Rectangle.NO_BORDER;

                acel1.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                acel11.Border = iTextSharp.text.Rectangle.NO_BORDER;

                row1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row11.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row12.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row13.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row14.Border = iTextSharp.text.Rectangle.NO_BORDER;

                arow1.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                arow11.Border = iTextSharp.text.Rectangle.NO_BORDER;

                cel1.HorizontalAlignment = Element.ALIGN_CENTER;
                cel2.HorizontalAlignment = Element.ALIGN_CENTER;
                cel3.HorizontalAlignment = Element.ALIGN_CENTER;
                cel4.HorizontalAlignment = Element.ALIGN_CENTER;
                cel5.HorizontalAlignment = Element.ALIGN_CENTER;
                cel6.HorizontalAlignment = Element.ALIGN_CENTER;
                cel7.HorizontalAlignment = Element.ALIGN_CENTER;
                cel8.HorizontalAlignment = Element.ALIGN_CENTER;
                cel9.HorizontalAlignment = Element.ALIGN_CENTER;
                cel10.HorizontalAlignment = Element.ALIGN_CENTER;
                cel11.HorizontalAlignment = Element.ALIGN_CENTER;
                cel12.HorizontalAlignment = Element.ALIGN_CENTER;
                cel13.HorizontalAlignment = Element.ALIGN_CENTER;
                cel14.HorizontalAlignment = Element.ALIGN_CENTER;

                acel1.HorizontalAlignment = Element.ALIGN_CENTER;
                acel11.HorizontalAlignment = Element.ALIGN_CENTER;

                row1.HorizontalAlignment = Element.ALIGN_RIGHT;
                row2.HorizontalAlignment = Element.ALIGN_CENTER;
                row3.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row4.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row5.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row6.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row7.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row8.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row9.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row10.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row11.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row12.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row13.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row14.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                arow1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                arow11.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                table1.WidthPercentage = 100;
                table1.HorizontalAlignment = Element.ALIGN_RIGHT;

                table1.AddCell(cel1);
                table1.AddCell(row1);
                table1.AddCell(cel2);
                table1.AddCell(row2);
                table1.AddCell(cel3);
                table1.AddCell(row3);
                table1.AddCell(cel4);
                table1.AddCell(row4);
                table1.AddCell(cel5);
                table1.AddCell(row5);
                table1.AddCell(cel6);
                table1.AddCell(row6);
                table1.AddCell(cel7);
                table1.AddCell(row7);
                table1.AddCell(cel8);
                table1.AddCell(row8);
                table1.AddCell(cel9);
                table1.AddCell(row9);
                table1.AddCell(cel10);
                table1.AddCell(row11);
                table1.AddCell(cel11);
                table1.AddCell(row10);

                table1.AddCell(cel12);
                table1.AddCell(row13);
                table1.AddCell(cel13);
                table1.AddCell(row12);

                table1.AddCell(cel14);
                table1.AddCell(row14);


                table1.AddCell(acel11);
                table1.AddCell(arow11);

                table1.AddCell(acel1);
                table1.AddCell(arow1);

                table1.SpacingBefore = 25;
                doc.Add(table1);

                // second table

                int pri2 = rnd.Next(1, 500);

                PdfPTable table2 = new PdfPTable(2);
                table2.SetWidths(width);

                PdfPCell cel112 = new PdfPCell(new Phrase("O\'ZBEKISTON", f_15_bold));
                PdfPCell row112 = new PdfPCell(new Phrase("26-shakl", f_15_normal));
                PdfPCell cel22 = new PdfPCell(new Phrase("RESPUBLIKASI", f_15_bold));
                PdfPCell row22 = new PdfPCell(new Phrase("MA\'LUMOTNOMA", f_15_bold));
                PdfPCell cel32 = new PdfPCell(new Phrase("TRANSPORT", f_15_bold));
                PdfPCell row32 = new PdfPCell(new Phrase("Berildi   " + textBox11.Text + "   yilda tug’ilgan talaba", f_15_normal));
                PdfPCell cel42 = new PdfPCell(new Phrase("VAZIRLIGI", f_15_bold));
                PdfPCell row42 = new PdfPCell(new Phrase(textBox12.Text, f_15_normal));
                PdfPCell cel52 = new PdfPCell(new Phrase("TOSHKENT DAVLAT", f_15_bold));
                PdfPCell row52 = new PdfPCell(new Phrase("" + textBox13.Text[6] + textBox13.Text[7] + textBox13.Text[8] + textBox13.Text[9] + " yil " + textBox13.Text[3] + textBox13.Text[4] + " “ " + textBox13.Text[0] + textBox13.Text[1] + " ”  kundagi  " + textBox14.Text + "  sonli buyruq asosida Toshkent Davlat", f_15_normal));
                PdfPCell cel62 = new PdfPCell(new Phrase("TRANSPORT", f_15_bold));
                PdfPCell row62 = new PdfPCell(new Phrase("Transport Universitetiga o\'qishga qabul qilindi va hozirgi kunda  " + textBox15.Text + "  bosqich ", f_15_normal));
                PdfPCell cel72 = new PdfPCell(new Phrase("UNIVERSITETI", f_15_bold));
                PdfPCell row72 = new PdfPCell(new Phrase("talabasi hisoblanadi. O\'qish davri  " + textBox16.Text + "  gacha davom etadi.", f_15_normal));
                PdfPCell cel82 = new PdfPCell(new Phrase("100167, Toshkent shahar,", f_15_bold));
                PdfPCell row82 = new PdfPCell(new Phrase("Ushbu ma\'lumot  " + textBox17.Text, f_15_normal));
                PdfPCell cel92 = new PdfPCell(new Phrase("Odilxo\'jaev ko\'chasi, 1", f_15_bold));
                PdfPCell row92 = new PdfPCell(new Phrase("Mudofaa ishlari bo\'limiga taqdim etish uchun berildi.", f_15_normal));
                PdfPCell cel120 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell row120 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell cel121 = new PdfPCell(new Phrase("No:   " + textBox10.Text, f_15_bold));
                PdfPCell row121 = new PdfPCell(new Phrase("  ", f_15_normal));

                PdfPCell acel2 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell arow2 = new PdfPCell(new Phrase("  ", f_15_bold));

                PdfPCell acel22 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell arow22 = new PdfPCell(new Phrase("  ", f_15_bold));

                PdfPCell cel122 = new PdfPCell(new Phrase("“" + textBox18.Text[0] + textBox18.Text[1] + "”-" + textBox18.Text[3] + textBox18.Text[4] + "-" + textBox18.Text[6] + textBox18.Text[7] + textBox18.Text[8] + textBox18.Text[9] + " ", f_15_bold));
                PdfPCell row122 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell cel123 = new PdfPCell(new Phrase("Telefon (71) 299-02-98", f_15_bold));
                PdfPCell row123 = new PdfPCell(new Phrase("             O\'quv ishlari bo\'yicha prorektor                               " + textBox28.Text, f_15_bold));
                PdfPCell cel124 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell row124 = new PdfPCell(new Phrase("             2-Bo\'lim boshlig\'i                                                     Sh.T.Shoxidayeva", f_15_bold));

                cel112.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel22.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel32.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel42.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel52.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel62.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel72.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel82.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel92.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel120.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel121.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel122.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel123.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel124.Border = iTextSharp.text.Rectangle.NO_BORDER;

                acel2.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                acel22.Border = iTextSharp.text.Rectangle.NO_BORDER;

                row112.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row22.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row32.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row42.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row52.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row62.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row72.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row82.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row92.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row120.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row121.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row122.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row123.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row124.Border = iTextSharp.text.Rectangle.NO_BORDER;

                arow2.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                arow22.Border = iTextSharp.text.Rectangle.NO_BORDER;

                cel112.HorizontalAlignment = Element.ALIGN_CENTER;
                cel22.HorizontalAlignment = Element.ALIGN_CENTER;
                cel32.HorizontalAlignment = Element.ALIGN_CENTER;
                cel42.HorizontalAlignment = Element.ALIGN_CENTER;
                cel52.HorizontalAlignment = Element.ALIGN_CENTER;
                cel62.HorizontalAlignment = Element.ALIGN_CENTER;
                cel72.HorizontalAlignment = Element.ALIGN_CENTER;
                cel8.HorizontalAlignment = Element.ALIGN_CENTER;
                cel92.HorizontalAlignment = Element.ALIGN_CENTER;
                cel120.HorizontalAlignment = Element.ALIGN_CENTER;
                cel121.HorizontalAlignment = Element.ALIGN_CENTER;
                cel122.HorizontalAlignment = Element.ALIGN_CENTER;
                cel123.HorizontalAlignment = Element.ALIGN_CENTER;
                cel124.HorizontalAlignment = Element.ALIGN_CENTER;

                acel2.HorizontalAlignment = Element.ALIGN_CENTER;
                acel22.HorizontalAlignment = Element.ALIGN_CENTER;

                row112.HorizontalAlignment = Element.ALIGN_RIGHT;
                row22.HorizontalAlignment = Element.ALIGN_CENTER;
                row32.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row42.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row52.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row62.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row72.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row82.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row92.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row120.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row121.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row122.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row123.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row124.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                arow2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                arow22.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                table2.WidthPercentage = 100;
                table2.HorizontalAlignment = Element.ALIGN_LEFT;

                table2.AddCell(cel112);
                table2.AddCell(row112);
                table2.AddCell(cel22);
                table2.AddCell(row22);
                table2.AddCell(cel32);
                table2.AddCell(row32);
                table2.AddCell(cel42);
                table2.AddCell(row42);
                table2.AddCell(cel52);
                table2.AddCell(row52);
                table2.AddCell(cel62);
                table2.AddCell(row62);
                table2.AddCell(cel72);
                table2.AddCell(row72);
                table2.AddCell(cel82);
                table2.AddCell(row82);
                table2.AddCell(cel92);
                table2.AddCell(row92);
                table2.AddCell(cel120);
                table2.AddCell(row121);
                table2.AddCell(cel121);
                table2.AddCell(row120);

                table2.AddCell(cel122);
                table2.AddCell(row123);
                table2.AddCell(cel123);
                table2.AddCell(row122);

                table2.AddCell(cel124);
                table2.AddCell(row124);

                table2.AddCell(acel22);
                table2.AddCell(arow22);

                table2.AddCell(acel2);
                table2.AddCell(arow2);


                table2.SpacingAfter = 20;
                table2.SpacingBefore = 20;
                doc.Add(table2);

                // third table

                int pri3 = rnd.Next(1, 500);

                PdfPTable table3 = new PdfPTable(2);
                table3.SetWidths(width);

                PdfPCell cel113 = new PdfPCell(new Phrase("O\'ZBEKISTON", f_15_bold));
                PdfPCell row113 = new PdfPCell(new Phrase("26-shakl", f_15_normal));
                PdfPCell cel23 = new PdfPCell(new Phrase("RESPUBLIKASI", f_15_bold));
                PdfPCell row23 = new PdfPCell(new Phrase("MA\'LUMOTNOMA", f_15_bold));
                PdfPCell cel33 = new PdfPCell(new Phrase("TRANSPORT", f_15_bold));
                PdfPCell row33 = new PdfPCell(new Phrase("Berildi   " + textBox20.Text + "   yilda tug’ilgan talaba", f_15_normal));
                PdfPCell cel43 = new PdfPCell(new Phrase("VAZIRLIGI", f_15_bold));
                PdfPCell row43 = new PdfPCell(new Phrase(textBox21.Text, f_15_normal));
                PdfPCell cel53 = new PdfPCell(new Phrase("TOSHKENT DAVLAT", f_15_bold));
                PdfPCell row53 = new PdfPCell(new Phrase("" + textBox22.Text[6] + textBox22.Text[7] + textBox22.Text[8] + textBox22.Text[9] + " yil " + textBox22.Text[3] + textBox22.Text[4] + " “ " + textBox22.Text[0] + textBox22.Text[1] + " ”  kundagi  " + textBox23.Text + "  sonli buyruq asosida Toshkent Davlat", f_15_normal));
                PdfPCell cel63 = new PdfPCell(new Phrase("TRANSPORT", f_15_bold));
                PdfPCell row63 = new PdfPCell(new Phrase("Transport Universitetiga o\'qishga qabul qilindi va hozirgi kunda  " + textBox24.Text + "  bosqich ", f_15_normal));
                PdfPCell cel73 = new PdfPCell(new Phrase("UNIVERSITETI", f_15_bold));
                PdfPCell row73 = new PdfPCell(new Phrase("talabasi hisoblanadi. O\'qish davri  " + textBox25.Text + "  gacha davom etadi.", f_15_normal));
                PdfPCell cel83 = new PdfPCell(new Phrase("100167, Toshkent shahar,", f_15_bold));
                PdfPCell row83 = new PdfPCell(new Phrase("Ushbu ma\'lumot  " + textBox26.Text, f_15_normal));
                PdfPCell cel93 = new PdfPCell(new Phrase("Odilxo\'jaev ko\'chasi, 1", f_15_bold));
                PdfPCell row93 = new PdfPCell(new Phrase("Mudofaa ishlari bo\'limiga taqdim etish uchun berildi.", f_15_normal));
                PdfPCell cel130 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell row130 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell cel131 = new PdfPCell(new Phrase("No:   " + textBox19.Text, f_15_bold));
                PdfPCell row131 = new PdfPCell(new Phrase("  ", f_15_normal));

                //PdfPCell acel3 = new PdfPCell(new Phrase("  ", f_15_normal));
                //PdfPCell arow3 = new PdfPCell(new Phrase("  ", f_15_bold));

                //PdfPCell acel33 = new PdfPCell(new Phrase("  ", f_15_normal));
                //PdfPCell arow33 = new PdfPCell(new Phrase("  ", f_15_bold));

                PdfPCell cel132 = new PdfPCell(new Phrase("“" + textBox27.Text[0] + textBox27.Text[1] + "”-" + textBox27.Text[3] + textBox27.Text[4] + "-" + textBox27.Text[6] + textBox27.Text[7] + textBox27.Text[8] + textBox27.Text[9] + " ", f_15_bold));
                PdfPCell row132 = new PdfPCell(new Phrase("  ", f_15_normal));
                PdfPCell cel133 = new PdfPCell(new Phrase("Telefon (71) 299-02-98", f_15_bold));
                PdfPCell row133 = new PdfPCell(new Phrase("             O\'quv ishlari bo\'yicha prorektor                               " + textBox28.Text, f_15_bold));
                PdfPCell cel134 = new PdfPCell(new Phrase("  ", f_15_bold));
                PdfPCell row134 = new PdfPCell(new Phrase("             2-Bo\'lim boshlig\'i                                                     Sh.T.Shoxidayeva", f_15_bold));

                cel113.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel23.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel33.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel43.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel53.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel63.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel73.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel83.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel93.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel130.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel131.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel132.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel133.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel134.Border = iTextSharp.text.Rectangle.NO_BORDER;

                //acel3.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                //acel33.Border = iTextSharp.text.Rectangle.NO_BORDER;

                row113.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row23.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row33.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row43.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row53.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row63.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row73.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row83.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row93.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row130.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row131.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row132.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row133.Border = iTextSharp.text.Rectangle.NO_BORDER;
                row134.Border = iTextSharp.text.Rectangle.NO_BORDER;

                //arow3.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                //arow33.Border = iTextSharp.text.Rectangle.NO_BORDER;

                cel113.HorizontalAlignment = Element.ALIGN_CENTER;
                cel23.HorizontalAlignment = Element.ALIGN_CENTER;
                cel33.HorizontalAlignment = Element.ALIGN_CENTER;
                cel43.HorizontalAlignment = Element.ALIGN_CENTER;
                cel53.HorizontalAlignment = Element.ALIGN_CENTER;
                cel63.HorizontalAlignment = Element.ALIGN_CENTER;
                cel73.HorizontalAlignment = Element.ALIGN_CENTER;
                cel83.HorizontalAlignment = Element.ALIGN_CENTER;
                cel93.HorizontalAlignment = Element.ALIGN_CENTER;
                cel130.HorizontalAlignment = Element.ALIGN_CENTER;
                cel131.HorizontalAlignment = Element.ALIGN_CENTER;
                cel132.HorizontalAlignment = Element.ALIGN_CENTER;
                cel133.HorizontalAlignment = Element.ALIGN_CENTER;
                cel134.HorizontalAlignment = Element.ALIGN_CENTER;

                //acel3.HorizontalAlignment = Element.ALIGN_CENTER;
                //acel33.HorizontalAlignment = Element.ALIGN_CENTER;

                row113.HorizontalAlignment = Element.ALIGN_RIGHT;
                row23.HorizontalAlignment = Element.ALIGN_CENTER;
                row33.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row43.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row53.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row63.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row73.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row83.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row93.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row130.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row131.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row132.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row133.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                row134.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                //arow3.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                //arow33.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                table3.WidthPercentage = 100;
                table3.HorizontalAlignment = Element.ALIGN_CENTER;

                table3.AddCell(cel113);
                table3.AddCell(row113);
                table3.AddCell(cel23);
                table3.AddCell(row23);
                table3.AddCell(cel33);
                table3.AddCell(row33);
                table3.AddCell(cel43);
                table3.AddCell(row43);
                table3.AddCell(cel53);
                table3.AddCell(row53);
                table3.AddCell(cel63);
                table3.AddCell(row63);
                table3.AddCell(cel73);
                table3.AddCell(row73);
                table3.AddCell(cel83);
                table3.AddCell(row83);
                table3.AddCell(cel93);
                table3.AddCell(row93);
                table3.AddCell(cel130);
                table3.AddCell(row131);
                table3.AddCell(cel131);
                table3.AddCell(row130);

                table3.AddCell(cel132);
                table3.AddCell(row133);
                table3.AddCell(cel133);
                table3.AddCell(row132);

                table3.AddCell(cel134);
                table3.AddCell(row134);

                //table3.AddCell(acel33);
                //table3.AddCell(arow33);

                //table3.AddCell(acel3);
                //table3.AddCell(arow3);


                table3.SpacingAfter = 25;
                doc.Add(table3);

                doc.Close();
                System.Diagnostics.Process.Start(path + "\\Ma\'lumotnoma_" + name.ToString() + ".pdf");

                Cleaner();
            }
        }

        private void Checker()
        {
            if (textBox1.Text.Length == 0)
                textBox1.Text = "___________";
            if (textBox2.Text.Length == 0)
                textBox2.Text = "____________";
            if (textBox3.Text.Length == 0)
                textBox3.Text = "_______________________________________________________________";
            if (textBox4.Text.Length == 0)
                textBox4.Text = "__________";
            if (textBox5.Text.Length == 0)
                textBox5.Text = "______";
            if (textBox6.Text.Length == 0)
                textBox6.Text = "____";
            if (textBox7.Text.Length == 0)
                textBox7.Text = "__________";
            if (textBox8.Text.Length == 0)
                textBox8.Text = "_________________________________________________";
            if (textBox9.Text.Length == 0)
                textBox9.Text = "_______________________________________________";


            if (textBox10.Text.Length == 0)
                textBox10.Text = "___________";
            if (textBox11.Text.Length == 0)
                textBox11.Text = "____________";
            if (textBox12.Text.Length == 0)
                textBox12.Text = "_______________________________________________________________";
            if (textBox13.Text.Length == 0)
                textBox13.Text = "__________";
            if (textBox14.Text.Length == 0)
                textBox14.Text = "______";
            if (textBox15.Text.Length == 0)
                textBox15.Text = "____";
            if (textBox16.Text.Length == 0)
                textBox16.Text = "__________";
            if (textBox17.Text.Length == 0)
                textBox17.Text = "_________________________________________________";
            if (textBox18.Text.Length == 0)
                textBox18.Text = "_______________________________________________";


            if (textBox19.Text.Length == 0)
                textBox19.Text = "___________";
            if (textBox20.Text.Length == 0)
                textBox20.Text = "____________";
            if (textBox21.Text.Length == 0)
                textBox21.Text = "_______________________________________________________________";
            if (textBox22.Text.Length == 0)
                textBox22.Text = "__________";
            if (textBox23.Text.Length == 0)
                textBox23.Text = "______";
            if (textBox24.Text.Length == 0)
                textBox24.Text = "____";
            if (textBox25.Text.Length == 0)
                textBox25.Text = "__________";
            if (textBox26.Text.Length == 0)
                textBox26.Text = "_________________________________________________";
            if (textBox27.Text.Length == 0)
                textBox27.Text = "_______________________________________________";
            if (textBox28.Text.Length == 0)
                textBox28.Text = "A.A.Gulyamov";
        }

        private void Cleaner()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
        }
    }
}
