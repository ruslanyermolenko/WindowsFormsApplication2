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

        private void MakeHeader (string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
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
                sw.Write("<Row>999</Row>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Column>999</Column>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("<sampleRate>1000</sampleRate>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<MinValueDpComponent>-32768</MinValueDpComponent>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<MaxValueDpComponent>32767</MaxValueDpComponent>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<BitCountDpComponent>16</BitCountDpComponent>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<TubeDiameter>0</TubeDiameter>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</TubeRecordingInfo>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Info>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<NumRawChans>4</NumRawChans>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("<Name>1:280</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>1</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>280</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("<Name>2:130</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>2</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>130</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("<Name>3:60</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>3</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>60</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("<Name>4:60</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>4</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>60</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>2</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("</Root>"); // sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');

            }


        }
        public static int MakeWord(byte low, byte high)
        {
            return ((int)high << 8) | low;
        }

        private void SaveData(string inputFile, string outputfile)
        {
            FileStream outDatafile = new FileStream(outputfile, FileMode.Append);
            BinaryWriter outbinfile = new BinaryWriter(outDatafile);

            FileStream inDatafile = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            const int bufferSize = 16;
            int count;
            long fLen = inDatafile.Length;
            uint numPoints = (uint)(fLen - 1024) * 3;
            uint zero = 0;
            inDatafile.Seek(1024, 0);
            using (BinaryReader inbinfile = new BinaryReader(inDatafile))
            {
                byte[] buffer = new byte[bufferSize];

                // outbinfile.Write(inbinfile.ReadByte());
                //  numPoints = 4795; //hexadecimal values BB 12 00 00 represent decimal number 4795, the data points.
                //  byte[] byteArray_numPoints = BitConverter.GetBytes(numPoints);
                outbinfile.Write(numPoints);
                outbinfile.Write(zero);
                numPoints = numPoints / 48;
                outbinfile.Write(numPoints);

                int x280, x130, x60, x60a;
                int y280, y130, y60, y60a;


                while ((count = inbinfile.Read(buffer, 0, buffer.Length)) != 0)
                {
                    x280 = MakeWord(buffer[0] , buffer[1]);
                    y280 = MakeWord(buffer[2] , buffer[3]);

                    x130 = MakeWord(buffer[4], buffer[5]);
                    y130 = MakeWord(buffer[6], buffer[7]);

                    x60 = MakeWord(buffer[8], buffer[9]);
                    y60 = MakeWord(buffer[10], buffer[11]);

                    x60a = MakeWord(buffer[12], buffer[13]);
                    y60a = MakeWord(buffer[14], buffer[15]);

                    outbinfile.Write(x280);
                    outbinfile.Write(x130);
                    outbinfile.Write(x60);
                    outbinfile.Write(x60a);
                    outbinfile.Write(x60);
                    outbinfile.Write(x60a);

                    outbinfile.Write(y280);
                    outbinfile.Write(y130);
                    outbinfile.Write(y60);
                    outbinfile.Write(y60a);
                    outbinfile.Write(y60);
                    outbinfile.Write(y60a);

                }

            }

            outbinfile.Close();
            outDatafile.Dispose();
            inDatafile.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MakeHeader(linkLabel2.Text);
            SaveData(linkLabel1.Text, linkLabel2.Text);

        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
