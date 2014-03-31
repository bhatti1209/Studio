<!DOCTYPE HTML PUBLIC "-//IETF//DTD HTML//EN">
<html>

<head>
    <title>Enter/Edit Severity Information</title> <script language="Javascript"> <!--
//--></script>
    <style>UNKNOWN {
	TEXT-DECORATION: none
}
A:visited {
	COLOR: blue; TEXT-DECORATION: none
}
A.MO {
	TEXT-DECORATION: underline
}
A.MO:visited {
	TEXT-DECORATION: underline
}
</style>
    <meta content="Oracle PLSQL" name="GENERATOR" />
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <meta http-equiv="PRAGMA" content="NO-CACHE" />
    <meta http-equiv="Expires" content="-1" />
    <script language="JavaScript"> <!--
        function startSessionTimer() {
            setTimeout("timeoutWarning()", 6600000);
        }
        function timeoutWarning() {
            alert("Your Traction session has been idle for 110.00 minutes. Your session will end in 10.00 minutes. Click OK to continue.");
            setTimeout("timeoutSession()", 600000);
        }
        function timeoutSession() {
            window.location = "http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_SYSTEM.Session_Timeout";
        }
        function focus_first_field() {
            // loop through all forms on the page
            for (var f = 0; f < document.forms.length; f++) {
                // set frm variable so we don't have to call 'document.forms[f]' everywhere
                var frm = document.forms[f]
                // loop through all fields in the form
                for (var x = 0; x < frm.length; x++) {
                    // set fld variable so we don't have to call 'document.forms[f][x]' everywhere
                    var fld = frm[x]
                    // use a try/catch block so that if anything fails we just go to the next field
                    try {
                        if (!fld.isDisabled && !fld.readOnly) {
                            // I want to handle different field types differently, so switch on the type
                            switch (fld.type) {
                                // for text boxes, set the focus AND select the text, just like a Windows app
                                case 'text':
                                case 'password':
                                    if (fld.value == '') {
                                        fld.select()
                                        fld.focus()
                                    }
                                    else {
                                        var i = x + 1;
                                        for (i; i < frm.length; i++) {
                                            fld = frm[i]
                                            if (fld.value == '') {
                                                fld.select()
                                                fld.focus()
                                                break
                                            }
                                        }
                                    }
                                    return
                                case 'checkbox':
                                case 'radio':
                                    fld.select()
                                    fld.focus()
                                    return
                                    // select boxes and buttons can just have a simple focus() call
                                case 'select-one':
                                case 'select-multiple':
                                    fld.focus()
                                    return
                                case 'textarea':
                                    fld.focus()
                                    return
                            }
                        }
                    }
                    // if anything fails for any reason (hidden div, etc.), execution jumps to catch
                    // then goes through the loop again
                    catch (e)
{ }
                }
            }
        }
//--></script>
</head>
<body bgcolor="white" onload="startSessionTimer();focus_first_field();">
    <div id="overDiv" style="Z-INDEX: 1; POSITION: absolute">
    </div>
    <iframe id="ifrmCover" style="DISPLAY: none; LEFT: 0px; POSITION: absolute; TOP: 0px;" src="#" frameborder="0" scrolling="no" #000000?;?>
    </iframe>
    <script language="Javascript" src="http://brcirsa1n.amoco.com:7790/oratraqajs/overlibMini.js"> <!--
//--></script>
    <basefont face="Arial" size="2" />
    <center>
        <form id="EditForm" action="http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_Risk_Rank.Save_Record" method="post" runat="server">
            <asp:Table id="OuterTable" runat="server" BorderWidth="2" BorderStyle="Solid" BackColor="#C0C0C0">
                <asp:TableRow BorderWidth="4" BorderStyle="Double">
                    <asp:TableCell Width="100%" BackColor="#B7E1B2">
                        <asp:Table ID="Table1" Width="100%" BorderWidth="0" CellPadding="0" CellSpacing="0" runat="server" BackColor="#B7E1B2">
                            <asp:TableRow>
                                <asp:TableCell HorizontalAlign="LEFT" Width="99%" BackColor="#2D4B9F">
                                    <font color="#FFFFFF" face="Arial" size="2"><strong>Enter/Edit Severity Information</strong></font> 
                                </asp:TableCell>
                                <asp:TableCell Width="1%" HorizontalAlign="Right" BackColor="#2D4B9F">
                                    <a href="javascript:Cancel_Edit();"> 
                                    <asp:Image ID="Image1" ImageUrl="http://brcirsa1n.amoco.com:7790/oratraqaimages/close.gif" BorderWidth="0" runat="server" />
                                    </a> 
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell VerticalAlign="top" HorizontalAlign="center" BackColor="#B7E1B2" Width="100%">
                        <asp:Table ID="Table2" HorizontalAlign="Center" Width="100%" runat="server">
                            <asp:TableRow HorizontalAlign="CENTER">
                                <asp:TableCell HorizontalAlign="Left" Wrap="false">
                                    <input type="hidden" name="strID_" value="2893125" />
                                    <font face="Arial"><strong>Actual Severity Matrix</strong></font> 
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Table ID="Table3" BorderWidth="4" BorderStyle="Double" runat="server">
                                        <asp:TableRow HorizontalAlign="Center">
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" Wrap="false" Width="45">
                                                <font face="Arial" size="2"><strong>Severity Level</strong></font> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" Width="75">
                                                <font face="Arial" size="2"><strong>Health</strong></font> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" Width="75">
                                                <font face="Arial" size="2"><strong>Safety</strong></font> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" Width="75">
                                                <font face="Arial" size="2"><strong>Environmental</strong></font> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" Width="75">
                                                <font face="Arial" size="2"><strong>Equipment Damage</strong></font> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" Width="75">
                                                <font face="Arial" size="2"><strong>Privilege to Operate</strong></font> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" Width="100">
                                                <font face="Arial" size="2"><strong>Business Value Lost</strong></font> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center">
                                                <font face="Arial" size="2"><strong>Security</strong></font> 
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow ID="A3" HorizontalAlign="Center">
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <strong>A-D</strong> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>3 or more fatalities,actual or alleged resulting from illness.<LI>Identified onset of life threatening health effects in 3 or more workers<LI>30 or more health effects to BP workforce, either permanent or requiring hospital treatment for more than 24 hours</UL>',A3 )" onclick="return check_SeverityLevel(1, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity1_" ID="CB501" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>3 or more fatalities resulting from injuries <LI>30 or more injuries to BP workforce, either permanent or requiring hospital treatment for more than 24 hours </UL>',A3 )" onclick="return check_SeverityLevel(1, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity2_" ID="CB511" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Event with widespread or extensive damage to any environment and that remains in an unsatisfactory state for a period > 5 years<LI>Event with widespread or extensive damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of months or up to 1 year.<LI>Event with localized or extensive damage to a sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of months or up to 1 year.<LI>Event with widespread or extensive damage to a non-sensitive environment and that can only be remediated to a satisfactory / agreed state in a period of 2 - 4 years<LI>Event with extensive damage to a non-sensitive environment and that remains in an unsatisfactory state for a period > 5 years<LI>Event with widespread or extensive damage to a sensitive environment and that can only be remediated to a satisfactory / agreed state in a period of 2 - 4 years</UL>',A3 )" onclick="return check_SeverityLevel(1, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity3_" ID="CB521" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>>$10m equipment damage</UL>',A3 )" onclick="return check_SeverityLevel(1, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity4_" ID="CB531" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Public outrage or brand damage in major markets where we have presence or aspiration. <LI>Global or Regional media coverage or Severe National Outrage. <LI>Actual or threatened Loss of License to Operate.  <LI>Likely to lead to change of local, national or international regulations  </UL>',A3 )" onclick="return check_SeverityLevel(1, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity5_" ID="CB541" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>>$100m BVL</UL>',A3 )" onclick="return check_SeverityLevel(1, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity6_" ID="CB551" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Civil unrest in country requiring evacuation of staff<LI>Severe Terrorist / Guerrilla activity<LI>Hostage taking, Kidnap, Murder<LI>Severe criminal property damage</UL>',A3 )" onclick="return check_SeverityLevel(1, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity7_" ID="CB561" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow ID="A4" HorizontalAlign="center">
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <strong>E</strong> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>1 to 2 fatalities, actual or alleged resulting from illness.<LI>10-29 health effects to BP workforce, either permanent or requiring hospital treatment for more than 24 hours.</UL>',A4 )" onclick="return check_SeverityLevel(2, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity1_" ID="CB502" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>1-2 fatalities resulting from injury<LI>10-29 injuries to BP workforce, either permanent or requiring hospital treatment for more than 24 hours.</UL>',A4 )" onclick="return check_SeverityLevel(2, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity2_" ID="CB512" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Event with localized damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of @ 1 year<LI>Event with extensive damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of months.<LI>Event with localized damage to a sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of months<LI>Event with extensive damage to a sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of days or weeks</UL>',A4 )" onclick="return check_SeverityLevel(2, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity3_" ID="CB522" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>$1m-$10m property & equipment damage</UL>',A4 )" onclick="return check_SeverityLevel(2, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity4_" ID="CB532" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Localised or limited interest-group outrage in major market. Public or investor outrage in non-major markets<LI>Significant enforcement action (excluding fines) against one or more material assets in a significant market (eg US, Europe) with a foreseeable end date.</UL>',A3 )" onclick="return check_SeverityLevel(2, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity5_" ID="CB542" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>$5m to $100m BVL</UL>',A4 )" onclick="return check_SeverityLevel(2, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity6_" ID="CB552" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FF6666">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Serious criminal act (robbery, theft, burglary, property damage)<LI>Serious Terrorist / Guerrilla activity<LI>Serious assault / attack<LI>Serious breach of guidelines on handling security information<LI>Serious threat  / extortion<LI>Serious Strike, Protest, site seizure</UL>',A4 )" onclick="return check_SeverityLevel(2, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity7_" ID="CB562" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow ID="A5" HorizontalAlign="center">
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <strong>F</strong> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>1 or more permanent health partial disabilities<LI>Several non-permanent health impacts.<LI>DAFWC</UL>',A5 )" onclick="return check_SeverityLevel(3, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity1_" ID="CB503" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>1 or more permanent injury partial disabilities<LI>Several non-permanent injuries impacts.<LI>DAFWC</UL>',A5 )" onclick="return check_SeverityLevel(3, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity2_" ID="CB513" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Event with localized damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of months<LI>Event with immediate area damage to a sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of months<LI>Event with extensive damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of days or weeks<LI>Event with localized damage to a sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of days or weeks</UL>',A5 )" onclick="return check_SeverityLevel(3, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity3_" ID="CB523" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>$100k-$1m property & equipment damage</UL>',A5 )" onclick="return check_SeverityLevel(3, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity4_" ID="CB533" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Prolonged local media attention.<LI>Other enforcement action against one or more material assets in other market (not US or Europe) with a foreseeable end date</UL>',A5 )" onclick="return check_SeverityLevel(3, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity5_" ID="CB543" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>$500k-$5m BVL</UL>',A5 )" onclick="return check_SeverityLevel(3, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity6_" ID="CB553" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFCC66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Major Criminal act (robbery, theft, burglary, property damage)<LI>Major Terrorist / Guerrilla activity<LI>Short time retention / abduction<LI>Major Social Unrest<LI>Major Assault<LI>Major extortion<LI>Bomb threat<LI>Significant breach of guidelines on handling security information</UL>',A5 )" onclick="return check_SeverityLevel(3, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity7_" ID="CB563" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow ID="A6" HorizontalAlign="center">
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <strong>G</strong> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Single or Multiple recordable health effects from common source/event.</UL>',A6 )" onclick="return check_SeverityLevel(4, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity1_" ID="CB504" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Single or Multiple recordable injury from common source/event.</UL>',A6 )" onclick="return check_SeverityLevel(4, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity2_" ID="CB514" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Event with immediate area damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of months<LI>Event with localized damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of days or weeks<LI>Event with immediate area damage to a sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of days or weeks</UL>',A6 )" onclick="return check_SeverityLevel(4, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity3_" ID="CB524" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>$25k-$100k property & equipment damage<LI>Minimum Severity for any incident involving a road vehicle rollover.<LI>Minimum Severity Level for any incident incurring disabling damage requiring road vehicle(s) to be recovered from the scene.</UL>',A6 )" onclick="return check_SeverityLevel(4, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity4_" ID="CB534" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Short term local media coverage.<LI>Some disruption to day to day lives (e.g. loss of single road access less than 24 hours).<LI>Fines or other penalties significant to a BU.</UL>',A6 )" onclick="return check_SeverityLevel(4, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity5_" ID="CB544" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>$50k -$500k BVL</UL>',A6 )" onclick="return check_SeverityLevel(4, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity6_" ID="CB554" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#FFFF66">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Breach of company policies leading to formal disciplinary action<LI>Minor assault<LI>Minor robbery, burglary, criminal property damage<LI>Minor Criminal property damage<LI>Minor social unrest (demonstration, protest)</UL>',A6 )" onclick="return check_SeverityLevel(4, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity7_" ID="CB564" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow ID="A7" HorizontalAlign="center">
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <strong>H</strong> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>First aid<LI>Single or multiple over-exposures causing noticeable irritation but no actual health effects</UL>',A7 )" onclick="return check_SeverityLevel(5, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity1_" ID="CB505" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>First aid<LI>Single or multiple over-exposures causing noticeable irritation but no actual health effects.</UL>',A7 )" onclick="return check_SeverityLevel(5, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity2_" ID="CB515" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Event with immediate area damage to a non-sensitive environment and that can be remediated to a level that restores its environmental amenity in a period of days or weeks</UL>',A7 )" onclick="return check_SeverityLevel(5, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity3_" ID="CB525" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI><$25k property & equipment damage</UL>',A7 )" onclick="return check_SeverityLevel(5, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity4_" ID="CB535" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>No community notification<LI>Isolated and short term complaints from neighbours (e.g. complaints about specific noise episode).<LI>Code of Conduct violation which does not lead to higher severity level consequence.</UL>',A7 )" onclick="return check_SeverityLevel(5, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity5_" ID="CB545" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI><$50k BVL</UL>',A7 )" onclick="return check_SeverityLevel(5, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity6_" ID="CB555" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                            <asp:TableCell BorderWidth="4" BorderStyle="Double" HorizontalAlign="Center" BackColor="#ECEEF7">
                                                <a href="javascript:void(0);" onmousemove="return DisplayLIB('<UL><LI>Breach of company policies leading to formal disciplinary action<LI>Minor theft<LI>Minor threat</UL>',A7 )" onclick="return check_SeverityLevel(5, 0)" onmouseout="nd();"> 
                                                <asp:RadioButton GroupName="strSeverity7_" ID="CB565" runat="server" />
                                                </a> 
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="top" BackColor="#B7E1B2">
                        <input type="Button" value="Help" language="JavaScript" onclick="Display_Help2();" />
                        &nbsp; 
                        <input type="Button" value="Cancel" language="JavaScript" onclick="Cancel_Edit();" />
                        &nbsp; 
                        <input type="Button" value="Reset" language="JavaScript" onclick="Clear_Form1();" />
                        &nbsp; 
                        <input type="Button" value="< Previous" language="JavaScript" onclick="Previous_Screen();" />
                        &nbsp; 
                        <input type="Button" value="Next >" language="JavaScript" onclick="Verify_Data();" />
                    &nbsp;
                </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </form>
    </center>
    <script language="Javascript"> <!--
    function Cancel_Edit() {
        var closeit = false;
        closeit = confirm("Are you sure you want to close this window? Clicking OK will delete the record.")
        if (closeit)
        { location.href = "HSE_IRI_Common.Remove_IR?strID_=2893125" }
    }
    function Cancel_Save() {
        var closeit = false;
        closeit = confirm("Are you sure you want to close this window?")
        if (closeit) {
            document.EditForm.action = "http://brcirsa1n.amoco.com:7790/pls/oratraqa/Hse_IRI_Injury_Illness.Save_Record2";
            document.EditForm.submit();
        }
    }
    function Close_Window()
    { location.href = "HSE_IRI_Common.Remove_IR?strID_=2893125" }
    function Back_Screen()
    { location.href = "http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_Risk_Rank.Edit_Screen?strID_=2893125&strFlag_=A&StrMode_=1&strSwitch_=10020~~1~1~2893125~~!11577~~1~2893125~2~L!11577~;3~1~2893125~1~N!12701~;2;3~1~2893125!11461~;2;3~1~2893125!10067~;2;3~1~2893125!10066~~1~2893125!50016~1~1~~1~2893125!" }
    function Display_Help2() {
        window.open('http://traction.bpweb.bp.com/traction/general_help/traction.htm', 'helpwin', 'toolbar=0,scrollbars=yes,menubar=0,status=0,width=650,height=400');
    }

    function Clear_Form1() {

        for (i = 1; i < 6; i++) {
            for (q = 0; q < 7; q++) {
                var idval = "CB5" + q + i;
                var temp = document.getElementById(idval);

                temp.checked = false;
            }
        }
    }

    function check_SeverityLevel(SelectedSeverityLevel, SeverityLevel) {
    }

    function check_SeverityLevel1(SelectedSeverityLevel, SeverityLevel) {
        if ((SelectedSeverityLevel > SeverityLevel) && (SeverityLevel != 0)) {
            alert(" The potential severity must always be equal to or greater than the actual severity. Please review your selections.");
            return (false);
        }
        return (true);
    }

    function DisplayLIB(str, A1) {
        var ot = A1.offsetTop;
        while ((A1 = A1.offsetParent) != null)
            ot += A1.offsetTop;
        overlib(str, LEFT, BELOW)
        if (document.all) {
            getBrowserVersion();
            if (browser == "Internet Explorer" && !(parseInt(version) <= 5 && parseInt(minversion) == 0)) {
                PositionIFrame('overDiv', 'ifrmCover');
            }
        }
    }

    function Verify_Data() {
    
        var counter = 0;
        for (var q = 1; q <= 7; q++) {
            if (q != 6) {
                var rb = document.getElementsByName("strSeverity" + q + "_");
                
                if (rb(0).checked == true) {
                    if (q == 7)
                        counter = 2;
                    else
                        counter = 1;
                }
                if (rb(1).checked == true) {
                    if (q == 7)
                        counter = 2;
                    else
                        counter = 1;
                }
            }
        }
        if (counter > 0) {
            var oDialog;

            if (counter == 2) {
                //redirect to sec. pop-up
                oDialog = "Pop2.html?strMode_=1&strFlag_=2&strSecutityFlag_=1";
            }
            else if (counter == 1) {
                //redirect to normal pop-up
                oDialog = "Pop1.html?strMode_=1&strFlag_=2";
            }
            
            showModelessDialog(oDialog, window, "status:no;dialogWidth:630px;dialogHeight:370px;help:no;resizable=No");
        }
        else {
            //no pop-up just redirect
            window.location = "PRM.aspx";
        }
    }

    function Previous_Screen() {
        window.location="Illness.aspx";
    }

    function fnUpdate() {
        if (bDialogStatus == true) {
            window.location = "PRM.aspx?cd=1";
        }
    }    
//--></script>
    <form name="PreviousForm" action="http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_Risk_Rank.Edit_Screen" method="post">
        <input type="hidden" value="2893125" name="strID_" />
        <input type="hidden" value="A" name="strFlag_" />
        <input type="hidden" value="1" name="StrMode_" />
        <input type="hidden" value="10020~~1~1~2893125~~!11577~~1~2893125~2~L!11577~;3~1~2893125~1~N!12701~;2;3~1~2893125!11461~;2;3~1~2893125!10067~;2;3~1~2893125!10066~~1~2893125!50016~1~1~~1~2893125!" name="strSwitch_" />
    </form>
</body>
</html>