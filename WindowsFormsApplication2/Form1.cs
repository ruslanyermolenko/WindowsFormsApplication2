﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public string Series1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = "C:\\";
            openFileDialog1.ShowDialog();
            linkLabel1.Text = openFileDialog1.FileName;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            saveFileDialog1.FileName = "C:\\";
            saveFileDialog1.ShowDialog();
            linkLabel2.Text = saveFileDialog1.FileName;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            linkLabel3.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                       System.IO.FileStream fSysInput = new System.IO.FileStream(linkLabel1.Text, System.IO.FileMode.Open);
                       System.IO.FileStream fSysOutput = new System.IO.FileStream(linkLabel2.Text, System.IO.FileMode.Create);



                   byte[] buffer = new byte[256];
                   int CountReader = 0;
                   while ((CountReader = fSysInput.Read(buffer, 0, buffer.Length)) > 0)
                   {
                       fSysOutput.Write(buffer, 0, CountReader);

                   }
                   fSysInput.Close();
                   fSysOutput.Close();

                   int i = 0;
                   progressBar1.Value = 0;
                   progressBar1.Refresh();
                   double a;
                   int l;

                   chart1.Series[0].Points.Clear();

                   for (int k = 0; k < 360; k++)
                   {
                       a = Math.Sin(Math.PI/180*k);
                       progressBar1.Increment(1);
                       chart1.Series[0].Points.AddXY(k, a);

                   }
                   timer1.Interval = 1000;
                   timer1.Start();
                   progressBar1.Value = 0;
       */

            /*           XmlTextWriter textWritter = new XmlTextWriter(linkLabel3.Text + "\\save.xml");
                       textWritter.WriteStartDocument();

                       textWritter.WriteStartElement("Root");
                       textWritter.WriteAttributeString("Type", "Inetec.Utility.Persistency.InetecFileHeader");
                              textWritter.WriteEndElement();
                       textWritter.Close();

                       XmlDocument xml_doc = new XmlDocument();
                       xml_doc.Load(linkLabel3.Text + "\\save.xml");
                       //  xml_doc.DocumentElement.ChildNodes.
                       //      xml_doc.Load("X.xml");
                       XmlNode headerVersion = xml_doc.CreateElement("headerVersion");
                       headerVersion.InnerText = "1";
                       xml_doc.DocumentElement.AppendChild(headerVersion);
                       XmlNode fileType = xml_doc.CreateElement("fileType");
                       fileType.InnerText = "EddyOneTubeRawData";
                       xml_doc.DocumentElement.AppendChild(fileType);



                       xml_doc.Save(linkLabel3.Text + "\\save.xml");
               */


            using (StreamWriter sw = new StreamWriter(linkLabel2.Text, false, System.Text.Encoding.Default))
            {
                sw.Write("f"); sw.Write('\x01');
                sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"Inetec.Utility.Persistency.InetecFileHeader\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<headerVersion>1</headerVersion>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<fileType>EddyOneTubeRawData</fileType>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<createdByApplication>EddyOne Analysis 2013</createdByApplication>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<versionMajor>2</versionMajor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<versionMinor>2</versionMinor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<dalAssemblyVersion>1.2.1.0</dalAssemblyVersion>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("</Root>"); sw.Write('л'); sw.Write('\x03'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.TubeRawData\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<TubeId>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Row>992</Row>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Column>997</Column>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Section>999</Section>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ObjectName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ObjectName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Plant>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Plant>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Unit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Unit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</TubeId>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<TubeRecordingInfo>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<RecordingSpeed>0</RecordingSpeed>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<RecordingDirection>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>2</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</RecordingDirection>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<RecordedFromLeg>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>1</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</RecordedFromLeg>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<SyncToEncoder>False</SyncToEncoder>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<sampleRate>400000</sampleRate>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<MinValueDpComponent>-32768</MinValueDpComponent>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<MaxValueDpComponent>32767</MaxValueDpComponent>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<BitCountDpComponent>16</BitCountDpComponent>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<TubeDiameter>0</TubeDiameter>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</TubeRecordingInfo>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Info>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<NumRawChans>6</NumRawChans>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<NumEncoders>0</NumEncoders>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<AcquireTime>636103189004516907</AcquireTime>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<NumberOfProbes>1</NumberOfProbes>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Info>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>3</Id>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("</Root>"); sw.Write('+'); sw.Write('\x02'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');


                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.ChannelData\">"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>0</Id>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Name>1:400</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>1</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>400</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>1</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>0</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Rotation>0</Rotation>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<HorzNull>0</HorzNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VertNull>0</VertNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Span>200</Span>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VoltScale>1</VoltScale>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Root>"); sw.Write('+'); sw.Write('\x02'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.ChannelData\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>1</Id>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Name>2:300</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>2</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>300</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>1</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>0</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Rotation>0</Rotation>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<HorzNull>0</HorzNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VertNull>0</VertNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Span>200</Span>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VoltScale>1</VoltScale>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Root>"); sw.Write('+'); sw.Write('\x02'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.ChannelData\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>2</Id>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Name>3:200</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>3</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>200</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("< value__>1</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>0</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Rotation>0</Rotation>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<HorzNull>0</HorzNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VertNull>0</VertNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Span>200</Span>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VoltScale>1</VoltScale>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Root>"); sw.Write('+'); sw.Write('\x02'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.ChannelData\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>3</Id>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Name>4:100</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>4</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>100</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>1</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>0</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</FrequencyUnit>");
                sw.Write("</ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Rotation>0</Rotation>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<HorzNull>0</HorzNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VertNull>0</VertNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Span>200</Span>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VoltScale>1</VoltScale>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Root>"); sw.Write('+'); sw.Write('\x02'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00'); sw.Write('\x00');
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.ChannelData\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>4</Id>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Name>5:679</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>5</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>679</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>1</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>0</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</FrequencyUnit>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Rotation>0</Rotation>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<HorzNull>0</HorzNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VertNull>0</VertNull>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Span>200</Span>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<VoltScale>1</VoltScale>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</ChannelSetupRaw>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Root>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            
        }
    }
}
