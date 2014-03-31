<%@ Page Language="C#" MasterPageFile="~/UI/PageDesign.Master" AutoEventWireup="true"
    CodeBehind="ARM.aspx.cs" Inherits="DraftWebPage.UI.IncidentReport.ARM" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DisplayData" runat="server">
    <div style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 482px; width: 724px">
        <asp:Label ID="Label1" Style="position: absolute; top: 30px; left: 251px; width: 211px;"
            runat="server" Text="Enter/Edit Severity Information" Font-Italic="True" Font-Underline="True"
            ForeColor="#009900"></asp:Label>
        <asp:Panel runat="server" runat="server" BackColor="#E0F2B5" 
            BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" Style="z-index: 1; left: 14px; top: 63px; position: absolute;
            height: 416px; width: 698px">
            <asp:Table ID="ARMTable" GridLines="Both" runat="server" Style="z-index: 1; left: 12px;
                top: 46px; position: absolute; height: 280px; width: 677px" BorderColor="#666666"
                BorderStyle="Double" BorderWidth="5px">
                <asp:TableRow HorizontalAlign="Center">
                    <asp:TableCell HorizontalAlign="Center" Wrap="false" BackColor="#005300" Width="45">
                                                <font face="Arial" color="white" size="2"><strong>Severity Level</strong></font> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" Width="75" BackColor="#009900">
                                                <font face="Arial" color="white" size="2"><strong>Health</strong></font> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" Width="75" BackColor="#005300">
                                                <font face="Arial" color="white" size="2"><strong>Safety</strong></font> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" Width="75" BackColor="#009900">
                                                <font face="Arial" color="white" size="2"><strong>Environmental</strong></font> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" Width="75" BackColor="#005300">
                                                <font face="Arial" color="white" size="2"><strong>Equipment Damage</strong></font> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" Width="75" BackColor="#009900">
                                                <font face="Arial" color="white" size="2"><strong>Privilege to Operate</strong></font> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" Width="100" BackColor="#005300">
                                                <font face="Arial" color="white" size="2"><strong>Business Value Lost</strong></font> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#009900">
                                                <font face="Arial" color="white" size="2"><strong>Security</strong></font> 
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="A3" HorizontalAlign="Center">
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                                                <strong>A-D</strong> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity1_" ID="CB501" runat="server" />
                            <span>
                                <ul>
                                    <li>3 or more fatalities,actual or alleged resulting from illness.</li>
                                    </LI><li>Identified onset of life threatening health effects in 3 or more workers</li>
                                    </LI><li>30 or more health effects to BP workforce, either permanent or requiring hospital
                                        treatment for more than 24 hours</li>
                                </ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity2_" ID="CB511" runat="server" />
                            <span>
                                <ul>
                                    <li>3 or more fatalities resulting from injuries</li>
                                    </LI><li>30 or more injuries to BP workforce, either permanent or requiring hospital
                                        treatment for more than 24 hours</li>
                                </ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity3_" ID="CB521" runat="server" />
                            <span>
                                <ul>
                                    </LI><li>Event with widespread or extensive damage to any environment and that remains
                                        in an unsatisfactory state for a period > 5 years </li>
                                    </LI><li>Event with widespread or extensive damage to a non-sensitive environment and
                                        that can be remediated to a level that restores its environmental amenity in a period
                                        of months or up to 1 year. </li>
                                    </LI><li>Event with localized or extensive damage to a sensitive environment and that
                                        can be remediated to a level that restores its environmental amenity in a period
                                        of months or up to 1 year. </li>
                                    </LI><li>Event with widespread or extensive damage to a non-sensitive environment and
                                        that can only be remediated to a satisfactory / agreed state in a period of 2 -
                                        4 years </li>
                                    </LI><li>Event with extensive damage to a non-sensitive environment and that remains
                                        in an unsatisfactory state for a period > 5 years </li>
                                    </LI><li>Event with widespread or extensive damage to a sensitive environment and that
                                        can only be remediated to a satisfactory / agreed state in a period of 2 - 4 years
                                    </li>
                                </ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity4_" ID="CB531" runat="server" />
                            <span>
                                <ul>
                                    <li>>$10m equipment damage</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity5_" ID="CB541" runat="server" />
                            <span>
                                <ul>
                                    <li>Public outrage or brand damage in major markets where we have presence or aspiration.</li></LI><li>
                                        Global or Regional media coverage or Severe National Outrage.</li></LI><li>Actual or
                                            threatened Loss of License to Operate.</li></LI><li>Likely to lead to change of local,
                                                national or international regulations</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity6_" ID="CB551" runat="server" />
                            <span>
                                <ul>
                                    <li>>$100m BVL</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity7_" ID="CB561" runat="server" />
                            <span>
                                <ul>
                                    <li>Civil unrest in country requiring evacuation of staff</li><li>Severe Terrorist /
                                        Guerrilla activity</li><li>Hostage taking, Kidnap, Murder</li><li>Severe criminal property
                                            damage</li></ul>
                            </span></a>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="A4" HorizontalAlign="center">
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                                                <strong>E</strong> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity1_" ID="CB502" runat="server" />
                            <span>
                                <ul>
                                    <li>1 to 2 fatalities, actual or alleged resulting from illness.</li><li>10-29 health
                                        effects to BP workforce, either permanent or requiring hospital treatment for more
                                        than 24 hours.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity2_" ID="CB512" runat="server" />
                            <span>
                                <ul>
                                    <li>1-2 fatalities resulting from injury</li><li>10-29 injuries to BP workforce, either
                                        permanent or requiring hospital treatment for more than 24 hours.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity3_" ID="CB522" runat="server" />
                            <span>
                                <ul>
                                    <li>Event with localized damage to a non-sensitive environment and that can be remediated
                                        to a level that restores its environmental amenity in a period of @ 1 year</li><li>Event
                                            with extensive damage to a non-sensitive environment and that can be remediated
                                            to a level that restores its environmental amenity in a period of months.</li><li>Event
                                                with localized damage to a sensitive environment and that can be remediated to a
                                                level that restores its environmental amenity in a period of months</li><li>Event with
                                                    extensive damage to a sensitive environment and that can be remediated to a level
                                                    that restores its environmental amenity in a period of days or weeks</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity4_" ID="CB532" runat="server" />
                            <span>
                                <ul>
                                    <li>$1m-$10m property & equipment damage</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity5_" ID="CB542" runat="server" />
                            <span>
                                <ul>
                                    <li>Localised or limited interest-group outrage in major market. Public or investor
                                        outrage in non-major markets</li><li>Significant enforcement action (excluding fines)
                                            against one or more material assets in a significant market (eg US, Europe) with
                                            a foreseeable end date.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity6_" ID="CB552" runat="server" />
                            <span>
                                <ul>
                                    <li>$5m to $100m BVL</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FF6666">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity7_" ID="CB562" runat="server" />
                            <span>
                                <ul>
                                    <li>Serious criminal act (robbery, theft, burglary, property damage)</li><li>Serious
                                        Terrorist / Guerrilla activity</li><li>Serious assault / attack</li><li>Serious breach
                                            of guidelines on handling security information</li><li>Serious threat / extortion</li><li>
                                                Serious Strike, Protest, site seizure</li></ul>
                            </span></a>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="A5" HorizontalAlign="center">
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                                                <strong>F</strong> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity1_" ID="CB503" runat="server" />
                            <span>
                                <ul>
                                    <li>1 or more permanent health partial disabilities</li><li>Several non-permanent health
                                        impacts.</li><li>DAFWC</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity2_" ID="CB513" runat="server" />
                            <span>
                                <ul>
                                    <li>1 or more permanent injury partial disabilities</li><li>Several non-permanent injuries
                                        impacts.</li><li>DAFWC</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity3_" ID="CB523" runat="server" />
                            <span>
                                <ul>
                                    <li>Event with localized damage to a non-sensitive environment and that can be remediated
                                        to a level that restores its environmental amenity in a period of months</li><li>Event
                                            with immediate area damage to a sensitive environment and that can be remediated
                                            to a level that restores its environmental amenity in a period of months</li><li>Event
                                                with extensive damage to a non-sensitive environment and that can be remediated
                                                to a level that restores its environmental amenity in a period of days or weeks</li><li>
                                                    Event with localized damage to a sensitive environment and that can be remediated
                                                    to a level that restores its environmental amenity in a period of days or weeks</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity4_" ID="CB533" runat="server" />
                            <span>
                                <ul>
                                    <li>$100k-$1m property & equipment damage</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity5_" ID="CB543" runat="server" />
                            <span>
                                <ul>
                                    <li>Prolonged local media attention.</li><li>Other enforcement action against one or
                                        more material assets in other market (not US or Europe) with a foreseeable end date</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity6_" ID="CB553" runat="server" />
                            <span>
                                <ul>
                                    <li>$500k-$5m BVL</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFCC66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity7_" ID="CB563" runat="server" />
                            <span>
                                <ul>
                                    <li>Major Criminal act (robbery, theft, burglary, property damage)</li><li>Major Terrorist
                                        / Guerrilla activity</li><li>Short time retention / abduction</li><li>Major Social Unrest</li><li>
                                            Major Assault</li><li>Major extortion</li><li>Bomb threat</li><li>Significant breach
                                                of guidelines on handling security information</li></ul>
                            </span></a>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="A6" HorizontalAlign="center">
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                                                <strong>G</strong> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity1_" ID="CB504" runat="server" />
                            <span>
                                <ul>
                                    <li>Single or Multiple recordable health effects from common source/event.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity2_" ID="CB514" runat="server" />
                            <span>
                                <ul>
                                    <li>Single or Multiple recordable injury from common source/event.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity3_" ID="CB524" runat="server" />
                            <span>
                                <ul>
                                    <li>Event with immediate area damage to a non-sensitive environment and that can be
                                        remediated to a level that restores its environmental amenity in a period of months</li><li>
                                            Event with localized damage to a non-sensitive environment and that can be remediated
                                            to a level that restores its environmental amenity in a period of days or weeks</li><li>
                                                Event with immediate area damage to a sensitive environment and that can be remediated
                                                to a level that restores its environmental amenity in a period of days or weeks</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity4_" ID="CB534" runat="server" />
                            <span>
                                <ul>
                                    <li>$25k-$100k property & equipment damage</li><li>Minimum Severity for any incident
                                        involving a road vehicle rollover.</li><li>Minimum Severity Level for any incident incurring
                                            disabling damage requiring road vehicle(s) to be recovered from the scene.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity5_" ID="CB544" runat="server" />
                            <span>
                                <ul>
                                    <li>Short term local media coverage.</li><li>Some disruption to day to day lives (e.g.
                                        loss of single road access less than 24 hours).</li><li>Fines or other penalties significant
                                            to a BU.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity6_" ID="CB554" runat="server" />
                            <span>
                                <ul>
                                    <li>$50k -$500k BVL</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#FFFF66">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity7_" ID="CB564" runat="server" />
                            <span>
                                <ul>
                                    <li>Breach of company policies leading to formal disciplinary action</li><li>Minor assault</li><li>
                                        Minor robbery, burglary, criminal property damage</li><li>Minor Criminal property damage</li><li>
                                            Minor social unrest (demonstration, protest)</li></ul>
                            </span></a>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="A7" HorizontalAlign="center">
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <strong>H</strong> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity1_" ID="CB505" runat="server" />
                            <span>
                                <ul>
                                    <li>First aid</li><li>Single or multiple over-exposures causing noticeable irritation
                                        but no actual health effects</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity2_" ID="CB515" runat="server" />
                            <span>
                                <ul>
                                    <li>Event with immediate area damage to a non-sensitive environment and that can be
                                        remediated to a level that restores its environmental amenity in a period of days
                                        or weeks</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity3_" ID="CB525" runat="server" />
                            <span>
                                <ul>
                                    <li>Event with immediate area damage to a non-sensitive environment and that can be
                                        remediated to a level that restores its environmental amenity in a period of days
                                        or weeks</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity4_" ID="CB535" runat="server" />
                            <span>
                                <ul>
                                    <li><$25k property & equipment damage</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity5_" ID="CB545" runat="server" />
                            <span>
                                <ul>
                                    <li>No community notification</li><li>Isolated and short term complaints from neighbours
                                        (e.g. complaints about specific noise episode).</li><li>Code of Conduct violation which
                                            does not lead to higher severity level consequence.</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity6_" ID="CB555" runat="server" />
                            <span>
                                <ul>
                                    <li><$50k BVL</li></ul>
                            </span></a>
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center" BackColor="#ECEEF7">
                        <a class="ToolText" onmouseover="javascript:this.className='ToolTextHover'" onmouseout="javascript:this.className='ToolText'">
                            <asp:RadioButton GroupName="strSeverity7_" ID="CB565" runat="server" />
                            <span>
                                <ul>
                                    <li>Breach of company policies leading to formal disciplinary action</li><li>Minor theft</li><li>
                                        Minor threat</li></ul>
                            </span></a>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Label Style="position: absolute; top: 17px; left: 36px; height: 19px; width: 203px; right: 459px;"
                ID="Label2" runat="server" Text="Actual Severity Matrix" Font-Size="15pt"></asp:Label>
                
             <asp:ImageButton ID="NextButton" runat="server" ImageUrl="~/Images/Buttons/FrwdArrow2.jpg"
                Style="z-index: 3; left: 520px; top: 370px; position: absolute; height: 44px;
                width: 48px" OnClick="NextButton_Click" ToolTip="Next" />
            <asp:ImageButton ID="PreviousButton" runat="server" ImageUrl="~/Images/Buttons/BackButton2.jpg"
                Style="z-index: 3; left: 100px; top: 370px; position: absolute; height: 44px;
                width: 48px" OnClick="PreviousButton_Click" ToolTip="Previous" />
            <asp:ImageButton ID="HelpButton" runat="server" ImageUrl="~/Images/Buttons/HelpButton3.jpg"
                Style="z-index: 3; left: 250px; top: 370px; position: absolute; height: 44px;
                width: 48px" ToolTip="Help !!" />
            <asp:ImageButton ID="CancelButton" runat="server" ImageUrl="~/Images/Buttons/CancelButton4.jpg"
                Style="z-index: 3; left: 400px; top: 370px; position: absolute; height: 44px;
                width: 48px" OnClick="CancelButton_Click" ToolTip="Cancel" />
        </asp:Panel>
    </div>
</asp:Content>
