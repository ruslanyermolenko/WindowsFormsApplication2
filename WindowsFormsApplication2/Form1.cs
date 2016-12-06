/*! Program for convertation AIDA DEP files to EddyOne 
*/

using System;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) /// function for set input data file
        {
            openFileDialog1.FileName = "C:\\";
            openFileDialog1.ShowDialog();
            linkLabel1.Text = openFileDialog1.FileName;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) /// function for set output file
        {
            saveFileDialog1.FileName = "C:\\";
            saveFileDialog1.ShowDialog();
            linkLabel2.Text = saveFileDialog1.FileName;
        }

        private void Make_Header_block(string filename  ) /// <summary>
                                                        /// Make tmp file with Header block
                                                        /// </summary>
                                                        /// <param name="filename"></param>
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"Inetec.Utility.Persistency.InetecFileHeader\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<headerVersion>1</headerVersion>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<fileType>EddyOneTubeRawData</fileType>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<createdByApplication>EddyOne Analysis 2013</createdByApplication>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<versionMajor>2</versionMajor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<versionMinor>2</versionMinor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<dalAssemblyVersion>1.2.1.0</dalAssemblyVersion>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("</Root>");
            }

        }
        private void Make_tube_information(string filename, string row, string col, string Sec, string Id) /// <summary>
                                                            /// Make tmp file with First content block - recording tube information
                                                            /// </summary>
                                                            /// <param name="filename"></param>
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.TubeRawData\">"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<TubeId>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Row>"+ row + "</Row>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Column>" + col + "</Column>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Section>" + Sec + "</Section>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("<NumRawChans>4</NumRawChans>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<NumEncoders>0</NumEncoders>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<AcquireTime>636103189004516907</AcquireTime>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Comment>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<NumberOfProbes>1</NumberOfProbes>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("</Info>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>"+Id+"</Id>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("</Root>");
            }

      
        }

        private void Make_tube_channel_description(string filename, string Id, string Name, string ShortName, string Frequency, string Type_dif_abs)
        /// <summary>
        /// Make tmp file with Second content block - channel description
        /// </summary>
        /// <param name="filename"></param>
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                sw.Write("<?xml version=\"1.0\"?>"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<Root Type=\"DataLibrary.BE.ChannelData\">"); sw.Write('\x0D'); sw.Write('\x0A');
                sw.Write("<ChannelDescriptor>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Id>"+Id+"</Id>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Name>" + Name + "</Name>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<ShortName>" + ShortName + "</ShortName>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Frequency>" + Frequency + "</Frequency>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<Type>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
                sw.Write("<value__>" + Type_dif_abs + "</value__>"); sw.Write('\x0D'); sw.Write('\x0A'); sw.Write('\x20'); sw.Write('\x20');
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
                sw.Write("</Root>");
            }
        }
        private void MakeHeader (string filename) /// Header constructor
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
                sw.Write("</Root>");


                sw.Write('+'); sw.Write('\x02'); sw.Write('\x00'); sw.Write('\x00');
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
                sw.Write("</Root>");


                sw.Write('+'); sw.Write('\x02'); sw.Write('\x00'); sw.Write('\x00');
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
        public static int MakeWord(byte low, byte high) /// create int from 2 bytes,  little endian format
        {
            int tmpk = (int) high << 25;
            tmpk = tmpk >> 25;

            //    return ((int)high << 8) | low;
            return (tmpk << 8) | low;
        }

        private void SaveData(string inputFile, string outputfile) /// converter binary formats data
        {
            FileStream outDatafile = new FileStream(outputfile, FileMode.Append);
            BinaryWriter outbinfile = new BinaryWriter(outDatafile);
         /*   outbinfile.Seek(460, 0);
            outbinfile.Write(row);
            outbinfile.Seek(483, 0);
            outbinfile.Write(col);
            outbinfile.Seek(510, 0);
            outbinfile.Write(section);
            outbinfile.Seek((int)outDatafile.Length, 0);
            */

            FileStream inDatafile = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            const int bufferSize = 16;
            int count;
            long fLen = inDatafile.Length;
            uint numPoints = (uint)(fLen - 1024) * 2;
            int zero = 0;
            inDatafile.Seek(1024, 0);
            using (BinaryReader inbinfile = new BinaryReader(inDatafile))
            {
                byte[] buffer = new byte[bufferSize];

                // outbinfile.Write(inbinfile.ReadByte());
                //  numPoints = 4795; //hexadecimal values BB 12 00 00 represent decimal number 4795, the data points.
                //  byte[] byteArray_numPoints = BitConverter.GetBytes(numPoints);
                outbinfile.Write(numPoints);
                outbinfile.Write(zero);
                numPoints = numPoints / 32;
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
                                       
                    outbinfile.Write(y280);
                    outbinfile.Write(y130);
                    outbinfile.Write(y60);
                    outbinfile.Write(y60a);                  
                }

              }

              outbinfile.Close();
              outDatafile.Dispose();
              inDatafile.Dispose();
          }

private void Sum_files(string sourcefn, string destinfn) /// <summary>
                                                         /// function for compare files
                                                         /// </summary>
                                                         /// <param name="sourcefn"></param>
                                                         /// <param name="destinfn"></param>
        {
            FileStream outDatafile = new FileStream(destinfn, FileMode.Append);
            BinaryWriter outbinfile = new BinaryWriter(outDatafile);
            FileStream inDatafile = new FileStream(sourcefn, FileMode.Open, FileAccess.Read);
            int fLen = (int)inDatafile.Length;
            int zero = 0;
            int count;
            using (BinaryReader inbinfile = new BinaryReader(inDatafile))
            {
                outbinfile.Write(fLen);
                outbinfile.Write(zero);

                byte[] buffer = new byte[fLen];

                while ((count = inbinfile.Read(buffer, 0, buffer.Length)) != 0)
                {
                 outbinfile.Write(buffer, 0, count);
                }
            }
            outbinfile.Close();
            outDatafile.Dispose();
            inDatafile.Dispose();

        }

        private void Save_header(string sourcefn, string destinfn, string row, string col, string section) /// create header from template file
        {
   //            FileInfo fn = new FileInfo(sourcefn);

     //             fn.CopyTo(destinfn, true);

            FileStream outDatafile = new FileStream(destinfn, FileMode.Create);
            BinaryWriter outbinfile = new BinaryWriter(outDatafile);
            FileStream inDatafile = new FileStream(sourcefn, FileMode.Open, FileAccess.Read);
            //  const int bufferSize = 16;
            //      
            int row_index = 460;
            int col_index = 483;
            int sec_index = 510;
            int id_index =  1362;

            long fLen = inDatafile.Length;
            int count;
            using (BinaryReader inbinfile = new BinaryReader(inDatafile))
            {
                byte[] buffer = new byte[fLen];

                while ((count = inbinfile.Read(buffer, 0, buffer.Length)) != 0)
                {

                  for (int inx=0; inx < 3;   buffer[row_index + inx] = (byte)row[inx++]);
                  for (int inx = 0; inx < 3; buffer[col_index + inx] = (byte)col[inx++]);
                 for (int inx = 0; inx < 3; buffer[sec_index + inx] = (byte)section[inx++]);

                 buffer[id_index] = (byte)section[2];
   
                       outbinfile.Write(buffer, 0, count);
                }
            }
            outbinfile.Close();
            outDatafile.Dispose();
            inDatafile.Dispose();
            
        }

          private void button1_Click(object sender, EventArgs e)
          {
              //  MakeHeader(linkLabel2.Text);
              //Save_header(linkLabel3.Text, linkLabel2.Text);
       //       SaveData(linkLabel1.Text, linkLabel2.Text);

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

          private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) /// set file name with template header
          {
              openFileDialog1.FileName = Application.StartupPath + "\\hedear.aaa";
              openFileDialog1.ShowDialog();
              linkLabel3.Text = openFileDialog1.FileName;
          }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            linkLabel4.Text = folderBrowserDialog1.SelectedPath;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            linkLabel5.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(linkLabel4.Text, "*.DEP", SearchOption.AllDirectories);

            int index = 1;
            progressBar1.Maximum = files.Length;
            foreach (string infile in files)
            {
                string onlyfilename = Path.GetFileName(infile);

                string row = onlyfilename.Substring(1, 3);
                string col = onlyfilename.Substring(5, 3);

                string section = ""; 
                 if (index < 10 ) section  = "00" + index.ToString();
                 if ((index >= 10)&&(index < 100)) section = "0" + index.ToString();
                if (index >= 100) section =  index.ToString();
                index++;
                string outfile = linkLabel5.Text + "\\DHotR"+ row + "C" + col + "I" + section + ".aaa";

                Make_Header_block(Application.StartupPath + "\\Headrblok.tmp");
                Make_tube_information(Application.StartupPath + "\\tube_information.tmp", row, col, section, section);
                Make_tube_channel_description(Application.StartupPath + "\\280.tmp", "0", "F1:280", "F1", "280", "1");
                Make_tube_channel_description(Application.StartupPath + "\\130.tmp", "1", "F2:130", "F2", "130", "1");
                Make_tube_channel_description(Application.StartupPath + "\\60.tmp", "2", "F3:60", "F3", "60", "1");
                Make_tube_channel_description(Application.StartupPath + "\\60a.tmp", "3", "F4:60a", "F4", "60", "2");
                Sum_files(Application.StartupPath + "\\Headrblok.tmp", outfile);
                Sum_files(Application.StartupPath + "\\tube_information.tmp", outfile);
                Sum_files(Application.StartupPath + "\\280.tmp", outfile);
                Sum_files(Application.StartupPath + "\\130.tmp", outfile);
                Sum_files(Application.StartupPath + "\\60.tmp", outfile);
                Sum_files(Application.StartupPath + "\\60a.tmp", outfile);

                // Save_header(linkLabel3.Text, outfile, row, col, section);
                SaveData(infile, outfile);
                progressBar1.Increment(1);
                
            }

        }
    }
  }
