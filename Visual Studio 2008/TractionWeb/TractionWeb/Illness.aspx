<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>Incident Report Interviewer - Illness</title>
    <meta content="Oracle PLSQL" name="GENERATOR" />
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <meta http-equiv="PRAGMA" content="NO-CACHE" />
    <meta http-equiv="Expires" content="-1" />
    <script type="text/javascript"> <!--

        function startSessionTimer() {

            setTimeout("timeoutWarning()", 6600000);
        }

        var pagecount = 0;

        function pagecounter() {

            var start = location.search.indexOf("?pc=");

            if (start >= 0) {
                var end = location.search.indexOf("&", start) - 1;
                if (end < 0)
                    end = location.search.length;
                var result = '';
                for (var i = 4; i <= end; i++) {
                    var c = location.search.charAt(i);
                    result += c;
                }
                pagecount = result;
                var temp = document.getElementById("personline");
                temp.innerHTML += pagecount.toString();
            }
            else {
                if (pagecount == 0) {
                    pagecount++;
                    var temp = document.getElementById("personline");
                    temp.innerHTML += pagecount.toString();
                }
            }
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
    <script lanugage="javascript">

        strLastRow = '<asp:TableRow><asp:TableCell ColumnSpan="4">'

        strLastRow += '<input type="button" value="Add" onclick="addRow();">'

        strLastRow += '<FONT FACE="Arial" SIZE="2">&nbsp;&nbsp;Multiple injury/illnesses</FONT></asp:TableCell></asp:TableRow></asp:Table>';

        var crow = 1;

        function addRow() {

            objSpanObject = eval('document.all.allspans');

            strTemp = '<SPAN id=span' + nextRow + '><asp:TableRow><asp:TableCell><input type="button" value="Delete" onclick="deleteRow(' + nextRow + ');"></asp:TableRow><asp:TableCell align="left"><SELECT NAME="strBodyPart_" SIZE="1"><OPTION value="-1">- Needs Data -<OPTION value="36191">Abdomen<OPTION value="36197">Ankle<OPTION value="36189">Back<OPTION value="36202">Buttocks<OPTION value="48263">Cardiovascular<OPTION value="36190">Chest<OPTION value="36175">Ears<OPTION value="36183">Elbow<OPTION value="36174">Eyes<OPTION value="199217">Face<OPTION value="36187">Fingers<OPTION value="36198">Foot<OPTION value="36184">Forearm<OPTION value="48262">Gastro-Intestinal Tract<OPTION value="48261">Genito-Urinary Tract<OPTION value="36192">Groin<OPTION value="48260">Haemopoetic<OPTION value="36186">Hand<OPTION value="36178">Head<OPTION value="36193">Hip<OPTION value="36195">Knee<OPTION value="36196">Lower leg<OPTION value="584880">Lungs<OPTION value="36176">Mouth or Teeth<OPTION value="36177">Neck<OPTION value="73613">None<OPTION value="36179">Nose<OPTION value="36200">Respiratory Tract<OPTION value="584882">Ribs<OPTION value="36173">Scalp<OPTION value="36181">Shoulder<OPTION value="36188">Skin<OPTION value="36194">Thigh<OPTION value="36199">Toes<OPTION value="36182">Upper Arm<OPTION value="36185">Wrist</select></asp:TableRow><asp:TableCell align="LEFT"><SELECT NAME="strNatureOfInjury_" SIZE="1"><OPTION value="-1">- Needs Data -<OPTION value="36412">Amputation<OPTION value="36415">Asphyxiation<OPTION value="36416">Burn - chemical<OPTION value="36417">Burn - thermal<OPTION value="36426">Cancer & Malignant Blood Disorders<OPTION value="36418">Concussion<OPTION value="36419">Contusion/Bruise<OPTION value="36434">Death<OPTION value="36420">Dislocation<OPTION value="36441">Disorder due to Repeated, Cumulative Trauma<OPTION value="36422">Fracture<OPTION value="36433">Hearing Loss<OPTION value="36444">Heat Related Injury<OPTION value="36423">Hernia<OPTION value="36427">Laceration/Cut<OPTION value="36428">Loss of  Consciousness <OPTION value="199224">Needlestick or Sharps Injuries<OPTION value="36429">No Apparent Injury<OPTION value="36432">Other<OPTION value="36421">Other Diseases & Disorders<OPTION value="73640">Physical Assault<OPTION value="36439">Poisoning<OPTION value="36438">Respiratory Condition <OPTION value="73641">Sexual Assault<OPTION value="73638">Shot<OPTION value="36436">Skin Disease or Disorder<OPTION value="36431">Sprain or Strain</select></asp:TableRow><INPUT TYPE="hidden" NAME="strPPE_" VALUE="N"><INPUT TYPE="hidden" NAME="strCounter_" VALUE="' + nextRow + '"></span>';

            objSpanObject.innerHTML = objSpanObject.innerHTML.substr(0, objSpanObject.innerHTML.length - strLastRow.length + 2) + strTemp + strLastRow;

            alert(objSpanObject.innerHTML);
            nextRow++;

            numRowCount1++;
        }

        function addRow1() {

            crow++;
            var tr = document.getElementById('allspans');

            var IHM = tr.innerHTML.substr(0, tr.innerHTML.length - 16 - 267);

            IHM += "<TR style=\"BORDER-RIGHT: 2px double; BORDER-TOP : 2px double; BORDER-LEFT : 2px double; BORDER-BOTTOM: 2px double\" align=middle" + "ID=" + "addR" + ">";
            IHM += "<TD width=\"10 px\" style=\"BORDER-RIGHT: 2px double; BORDER-TOP : 2px double; BORDER-LEFT : 2px double; BORDER-BOTTOM: 2px double\" align=middle ID=" + "c1" + ">";
            IHM += "<input id='crow" + crow + "' type='button' value='Delete' onclick='deleteRow1(" + crow + ");'>";
            IHM += "</TD><TD style=\"BORDER-RIGHT: 2px double; BORDER-TOP : 2px double; BORDER-LEFT : 2px double; BORDER-BOTTOM: 2px double\" align=left" + "ID=" + "c2" + ">";
            IHM += document.getElementById('c2').innerHTML;
            IHM += "</TD><TD ID=c3 style=\"BORDER-RIGHT: 2px double; BORDER-TOP : 2px double; BORDER-LEFT : 2px double; BORDER-BOTTOM: 2px double\" align=left>";
            IHM += document.getElementById('c3').innerHTML;
            IHM += "</TD></TR>";
            IHM += "<TR><TD colspan=\"2\" align=\"LEFT\"><input type=button value=Add onclick=addRow1();><FONT face=Arial size=2>&nbsp;&nbsp;Multiple injury/Illnesses</FONT>";
            IHM += "</TD></TR></TBODY></TABLE>";

            tr.innerHTML = IHM;
        }

        function addRow2() {

            crow++;

            var x = document.getElementById('addT').insertRow(crow);

            var y = x.insertCell(0);

            var z = x.insertCell(1);

            var a = x.insertCell(2);

            y.innerHTML = "<input id='crow" + crow + "' type='button' value='Delete' onclick='deleteRow1(" + crow + ");'>";

            z.innerHTML = document.getElementById('c2').innerHTML;

            a.innerHTML = document.getElementById('c3').innerHTML;

        }

        function deleteRow1(rowid) {
            var table = document.getElementById('addT');
            var rowCount = table.rows.length;

            for (var i = 2; i < rowCount; i++) {
                var row = table.rows[i];
                var btn = row.cells[0].childNodes[0];
                var nm = "crow" + rowid;
                if (btn.id == nm) {
                    table.deleteRow(i);
                    crow--;

                    i = rowCount + 1;
                }
            }
        }

    </script>
    <script language="Javascript"> <!--

        function isValidDate(datein) {

            if (datein == "")

                return true;

            var indate = datein;

            if (indate.indexOf("-") !== -1) {

                var sdate = indate.split("-");

            }

            else {

                var sdate = indate.split("/");

            }

            var chkDate = new Date(Date.parse(sdate[1] + "/" + sdate[0] + "/" + sdate[2]));

            var cmpDate = (chkDate.getMonth() + 1) + "/" + (chkDate.getDate()) + "/" + (chkDate.getFullYear());

            var indate2 = (Math.abs(sdate[1])) + "/" + (Math.abs(sdate[0])) + "/" + (Math.abs(sdate[2]));

            if (indate2 !== cmpDate) {

                return false;

            }

            else {

                if (cmpDate == "NaN/NaN/NaN") {

                    return false;

                }

                else

                    if (sdate[2].length != 4) {

                    return false;

                }

                else {

                    return true;

                }

            }

        }

        function Convert_Date(datein) {

            var indate = datein;

            if (indate.indexOf("-") !== -1) {

                var sdate = indate.split("-");

            }

            else {

                var sdate = indate.split("/");

            }

            var chkDate = new Date(Date.parse(sdate[1] + "/" + sdate[0] + "/" + sdate[2]));

            return chkDate;

        }

        function openCalendar(dateField_) {

            window.open("Cal.html?strDestField_=" + dateField_.name + "&strDestForm_=" + dateField_.form.name, "subWindow", "resizable=0,toolbar=0,menubar=0,status=1,width=300,height=300,top=" + (screen.height - 300) / 2 + " ,left=" + (screen.width - 300) / 2);

        }

        function isFutureDate(datein, sysdate) {

            var indate = datein.split("/");

            var dd = indate[0];

            var mm = indate[1];

            var yy = indate[2];

            var indate = new Date();

            indate.setDate(dd);

            indate.setMonth(mm - 1);

            indate.setFullYear(yy);

            var futuredate = sysdate;

            var dd1 = futuredate.substring(0, 2);

            var mm1 = futuredate.substring(3, 5);

            var yy1 = futuredate.substring(6, 10);

            var futuredate = new Date();

            futuredate.setDate(dd1);

            futuredate.setMonth(mm1 - 1);

            futuredate.setFullYear(yy1);

            if (indate > futuredate) {

                return false;

            }

            return true;

        }

        function validateDate(dateField_) {

            if (!isValidDate(dateField_.value)) {

                dateField_.select();

                dateField_.focus();

                dateField_.value = "";

                openCalendar(dateField_);

                return false;

            }

        }

        function defaultDateFieldToToday(dateField_) {

            today = new Date();

            var month = "00";

            var date = "00";

            if ((today.getMonth() + 1) < 10) {

                month = "0" + (today.getMonth() + 1);

            } else {

                month = (today.getMonth() + 1);

            }

            if (today.getDate() < 10) {

                date = "0" + today.getDate();

            } else {

                date = today.getDate();

            }

            dateField_.value = date + "/" + month + "/" + today.getYear(); // the date

        }

//--></script>
</head>
<body bgcolor="white" onload="startSessionTimer();focus_first_field();pagecounter();">
    <script language="Javascript" src="http://brcirsa1n.amoco.com:7790/oratraqajs/overlibMini.js"> <!--

//--></script>
    <div id="overDiv" style="Z-INDEX: 1; VISIBILITY: hidden; POSITION: absolute">
    </div>
    <iframe id="ifrmCover" style="DISPLAY: none; LEFT: 0px; POSITION: absolute; TOP: 0px" src="#" frameborder="0" scrolling="no">
    </iframe>
    <basefont face="Arial" size="2" />
    <center>
        <form id="EditForm" name="EditForm" method="post" runat="server">
            <input type="hidden" name="strFlags_" />
            <input type="hidden" value="2893125" name="strID_" />
            <input type="hidden" value="1" name="strMode_" />
            <input type="hidden" value="2" name="strInjuryID_" />
            <input type="hidden" value="Y" name="strPersonalInfo_" />
            <input type="hidden" value="L" name="strIIFlag_" />
            <input type="hidden" value="402731" name="numSDBUID_" />
            <asp:Table ID="Table1" runat="server" BackColor="#b7e1b2" BorderStyle="Solid" BorderWidth="4">
                <asp:TableRow>
                    <asp:TableCell BorderWidth="3" Width="100%" BackColor="#b7e1b2">
                        <asp:Table ID="Table2" runat="server" CellSpacing="0" CellPadding="0" Width="100%" BackColor="#b7e1b2" BorderWidth="0">
                            <asp:TableRow>
                                <asp:TableCell Width="99%" BackColor="#2d4b9f" HorizontalAlign="Left">
                                    <font face="Arial" color="#ffffff" size="2"><strong>Incident Report Interviewer -
                                    Illness</strong></font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Right" Width="1%" BackColor="#2d4b9f">
                                    <a href="javascript:Cancel_Edit();"> <img src="http://brcirsa1n.amoco.com:7790/oratraqaimages/close.gif" border="0" /></a>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell VerticalAlign="Top" HorizontalAlign="Center" Width="100%" BackColor="#b7e1b2">
                        <asp:Table ID="Table3" Width="100%" HorizontalAlign="Center" BorderWidth="0" runat="server">
                            <asp:TableRow HorizontalAlign="Center">
                                <asp:TableCell Wrap="false" HorizontalAlign="Left" ColumnSpan="2">
                                    <font face="Arial" size="2"><strong id="personline">Please enter information for person </strong></font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Center">
                                <asp:TableCell Wrap="false" HorizontalAlign="Left" ColumnSpan="2">
                                    <font face="Arial" size="2"><strong>&nbsp;</strong></font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A1" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><u><a onmousemove="return DisplayLIB('The name of the individual involved. In some areas Given name is referred to as First Name and Family name is referred to as Last or Surname.',A1)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);"> Given
                                    Name:</a></u></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strgivenname_" MaxLength="75" Width="300" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A2" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><u>Middle Name:</u></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strmiddlename_" MaxLength="75" Width="300" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A3" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><a onmousemove="return DisplayLIB('The name of the individual involved. In some areas Given name is referred to as First Name and Family name is referred to as Last or Surname.',A3)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);"> Family
                                    Name:</a></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strfamilyname_" MaxLength="20" Width="200" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A4" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><u>Date of Birth (DD/MM/YYYY):</u></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <input onblur="validateDate(this);" type="text" maxlength="12" size="12" name="strdob_" />
                                    </font> <a href="javascript:openCalendar(document.EditForm.strdob_);"><img alt="Open Calendar" src="http://brcirsa1n.amoco.com:7790/oratraqaimages/nav_calendar.gif" align="absBottom" border="0" /> </a>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A5" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><u>Address:</u></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="straddress_" MaxLength="200" Width="350" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A6" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><u>Employee Number:</u></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="stremployeenumber_" MaxLength="30" Width="140" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow id="A7" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><a onmousemove="return DisplayLIB('U.S. enter SSN;  UK enter Social Insurance Number; etc.',A2)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);">National
                                    ID No.:</a></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strssn_" MaxLength="30" Width="140" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A8" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2">Gender:</font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strSex_" Width="70" runat="server">
                                        <asp:ListItem Value="M">Male</asp:ListItem>
                                        <asp:ListItem Selected="True" Value="F">Female</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A9" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2">Occupation:</font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strOccupation_" Width="140" runat="server">
                                        <asp:ListItem Selected="True" Value="-1">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="419493">Chemical User</asp:ListItem>
                                        <asp:ListItem Value="403334">occ 1</asp:ListItem>
                                        <asp:ListItem Value="403335">occ 2</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A10" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2">Experience:</font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strExperience_" Width="140" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="1">&lt; 1 year</asp:ListItem>
                                        <asp:ListItem Value="2">1-4 years</asp:ListItem>
                                        <asp:ListItem Value="3">5-9 years</asp:ListItem>
                                        <asp:ListItem Value="4">10-14 years</asp:ListItem>
                                        <asp:ListItem Value="5">15-19 years</asp:ListItem>
                                        <asp:ListItem Value="6">20-24 years</asp:ListItem>
                                        <asp:ListItem Value="7">25-29 years</asp:ListItem>
                                        <asp:ListItem Value="8">30-34 years</asp:ListItem>
                                        <asp:ListItem Value="9">35 and over years</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A11" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2">Location Type:</font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strLocationType_" Width="140" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="3">Company Premises</asp:ListItem>
                                        <asp:ListItem Value="4">Company Vehicle</asp:ListItem>
                                        <asp:ListItem Value="2">Offshore</asp:ListItem>
                                        <asp:ListItem Value="48411">Other</asp:ListItem>
                                        <asp:ListItem Value="5">Retail Site</asp:ListItem>
                                        <asp:ListItem Value="1">Ship</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A12" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2">Continuous Days Worked:</font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strcontinuousdays_" MaxLength="10" Width="80" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A13" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><strong>Worker Type:</strong></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strWorkerType_" Width="140" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="1">BP</asp:ListItem>
                                        <asp:ListItem Value="2">Contractor</asp:ListItem>
                                        <asp:ListItem Value="3">Third Party</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A14" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><strong>Company:</strong></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strCompany_" Width="350" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="2148843">Aral</asp:ListItem>
                                        <asp:ListItem Value="419490">Aral</asp:ListItem>
                                        <asp:ListItem Value="579201">Aramark</asp:ListItem>
                                        <asp:ListItem Value="579204">Aramark Vending</asp:ListItem>
                                        <asp:ListItem Value="579212">Arscott Cars</asp:ListItem>
                                        <asp:ListItem Value="579198">BP (Non Stream)</asp:ListItem>
                                        <asp:ListItem Value="419492">Bitumen</asp:ListItem>
                                        <asp:ListItem Value="419488">British Gas</asp:ListItem>
                                        <asp:ListItem Value="579221">Carlson Wagonlit</asp:ListItem>
                                        <asp:ListItem Value="579202">Catalyst Graphics</asp:ListItem>
                                        <asp:ListItem Value="2149465">Company3</asp:ListItem>
                                        <asp:ListItem Value="579223">EDS</asp:ListItem>
                                        <asp:ListItem Value="579233">Fujitsu</asp:ListItem>
                                        <asp:ListItem Value="579224">Geoquest</asp:ListItem>
                                        <asp:ListItem Value="579232">Getronics</asp:ListItem>
                                        <asp:ListItem Value="419487">Hays</asp:ListItem>
                                        <asp:ListItem Value="579230">IBM</asp:ListItem>
                                        <asp:ListItem Value="579203">ISS Cleaning</asp:ListItem>
                                        <asp:ListItem Value="579196">Interior</asp:ListItem>
                                        <asp:ListItem Value="579199">Iron Mountain/BDM</asp:ListItem>
                                        <asp:ListItem Value="579200">Johnson Controls</asp:ListItem>
                                        <asp:ListItem Value="579225">Kaleidoscope</asp:ListItem>
                                        <asp:ListItem Value="579213">Kinderquest</asp:ListItem>
                                        <asp:ListItem Value="579205">Lancaster Cleaning</asp:ListItem>
                                        <asp:ListItem Value="579214">Leisure Connection</asp:ListItem>
                                        <asp:ListItem Value="579222">Love &amp; Tate</asp:ListItem>
                                        <asp:ListItem Value="579206">M &amp; A Plants</asp:ListItem>
                                        <asp:ListItem Value="579215">MCH Buses</asp:ListItem>
                                        <asp:ListItem Value="579216">Mitie</asp:ListItem>
                                        <asp:ListItem Value="579207">Norland Managed Services</asp:ListItem>
                                        <asp:ListItem Value="579208">Oce</asp:ListItem>
                                        <asp:ListItem Value="579197">Overbury</asp:ListItem>
                                        <asp:ListItem Value="419491">P&amp;O</asp:ListItem>
                                        <asp:ListItem Value="579226">Phoenix</asp:ListItem>
                                        <asp:ListItem Value="579209">Pitney Bowes Management Services</asp:ListItem>
                                        <asp:ListItem Value="579210">Resolution</asp:ListItem>
                                        <asp:ListItem Value="579231">SAIC</asp:ListItem>
                                        <asp:ListItem Value="579229">Securiplan</asp:ListItem>
                                        <asp:ListItem Value="579219">Select Appointments</asp:ListItem>
                                        <asp:ListItem Value="579220">Strata</asp:ListItem>
                                        <asp:ListItem Value="579227">Syncordia</asp:ListItem>
                                        <asp:ListItem Value="1011978">Test</asp:ListItem>
                                        <asp:ListItem Value="579217">Waterers Landscape</asp:ListItem>
                                        <asp:ListItem Value="579211">William Lea</asp:ListItem>
                                        <asp:ListItem Value="579218">Wilson-James</asp:ListItem>
                                        <asp:ListItem Value="579228">Worldcom</asp:ListItem>
                                        <asp:ListItem Value="419489">bbb</asp:ListItem>
                                        <asp:ListItem Value="419484">clog</asp:ListItem>
                                        <asp:ListItem Value="403320">company 1</asp:ListItem>
                                        <asp:ListItem Value="403321">company 2</asp:ListItem>
                                        <asp:ListItem Value="2148955">deepa</asp:ListItem>
                                        <asp:ListItem Value="419486">motherwell bridge</asp:ListItem>
                                        <asp:ListItem Value="419485">tankfreight</asp:ListItem>
                                        <asp:ListItem Value="419483">zipper</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A15" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><strong>Classification:</strong></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strClassification_" Width="370" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="1">Not Job Related</asp:ListItem>
                                        <asp:ListItem Value="2">No Treatment</asp:ListItem>
                                        <asp:ListItem Value="4">First Aid</asp:ListItem>
                                        <asp:ListItem Value="5">Medical Treatment</asp:ListItem>
                                        <asp:ListItem Value="6">Restricted Work / Job Transfer</asp:ListItem>
                                        <asp:ListItem Value="8">Days Away From Work</asp:ListItem>
                                        <asp:ListItem Value="9">Workforce Fatality</asp:ListItem>
                                        <asp:ListItem Value="489079">3rd Party Fatality - Material Influence</asp:ListItem>
                                        <asp:ListItem Value="489080">3rd Party Fatality - No Material Influence</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A16" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><a onmousemove="return DisplayLIB('<b>Primary care:</b> First line care given following an incident, for instance an x ray to exclude injury and application of a bandage.<br><b>Secondary care:</b> Follow up care, for instance if an individual had to return for a further appointment the next day to check a dressing etc.<br><b>Tertiary care:</b> Ongoing care which could be for weeks or days, for instance physio following an incident.<br><b>Medevacuation:</b> When an ill or injured person is transferred to another location for continuing treatment. This can include transfer from original scene of incident  to more advanced health care facilities, or secondary transfer from health care setting in one country to alternative health care location in another country.<br><b>Medrescue:</b> Emergency medical rescue services for  individuals involved in an incident at a remote location to take them to nearest health care.On Site  Any care given while still at  main location, not requiring any further referral to offsite support.<br><b>On Site:</b> refers to any case where care given while the injured party is still at the BP Site not requiring any further referral to offsite support.',A16)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);">Treatment:</a></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strTreatment_" Width="150" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="2">Medivac</asp:ListItem>
                                        <asp:ListItem Value="3">Medrescue</asp:ListItem>
                                        <asp:ListItem Value="71536">No Treatment</asp:ListItem>
                                        <asp:ListItem Value="1">On-Site</asp:ListItem>
                                        <asp:ListItem Value="4">Primary Care</asp:ListItem>
                                        <asp:ListItem Value="48487">Secondary Care</asp:ListItem>
                                        <asp:ListItem Value="48488">Tertiary Care</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A17" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign= "Right">
                                    <font face="Arial" size="2"><strong>Type of Contact:</strong></font>
                                </asp:TableCell>
                                <asp:TableCell Wrap="false" HorizontalAlign="Left">
                                    <asp:DropDownList ID="strContact_" Width="250" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="48582">Biological Agents</asp:ListItem>
                                        <asp:ListItem Value="36244">Buried</asp:ListItem>
                                        <asp:ListItem Value="36226">Caught In, Under or Between</asp:ListItem>
                                        <asp:ListItem Value="48585">Chemical Dust</asp:ListItem>
                                        <asp:ListItem Value="36227">Chemical Liquid</asp:ListItem>
                                        <asp:ListItem Value="36235">Cold Substances (burns)</asp:ListItem>
                                        <asp:ListItem Value="36228">Cold Surfaces (burns)</asp:ListItem>
                                        <asp:ListItem Value="73637">Criminal Incident</asp:ListItem>
                                        <asp:ListItem Value="36229">Diving Related</asp:ListItem>
                                        <asp:ListItem Value="48583">Dust</asp:ListItem>
                                        <asp:ListItem Value="36230">Electricity</asp:ListItem>
                                        <asp:ListItem Value="36246">Ergonomics</asp:ListItem>
                                        <asp:ListItem Value="36231">Eyeflash</asp:ListItem>
                                        <asp:ListItem Value="36232">Fall from Height</asp:ListItem>
                                        <asp:ListItem Value="36233">Fall from Ladder/Steps</asp:ListItem>
                                        <asp:ListItem Value="36234">Fire or Explosion</asp:ListItem>
                                        <asp:ListItem Value="36236">Fume / Gas / Vapour</asp:ListItem>
                                        <asp:ListItem Value="48588">Hot Substances(burns)</asp:ListItem>
                                        <asp:ListItem Value="48589">Hot Surfaces (burns)</asp:ListItem>
                                        <asp:ListItem Value="36239">Loss of Containment</asp:ListItem>
                                        <asp:ListItem Value="36240">Machinery</asp:ListItem>
                                        <asp:ListItem Value="36237">Manual Handling</asp:ListItem>
                                        <asp:ListItem Value="48580">Noise</asp:ListItem>
                                        <asp:ListItem Value="36248">Other</asp:ListItem>
                                        <asp:ListItem Value="48586">Pressure (high)</asp:ListItem>
                                        <asp:ListItem Value="48587">Pressure (lo)</asp:ListItem>
                                        <asp:ListItem Value="48584">Psychosocial Factors</asp:ListItem>
                                        <asp:ListItem Value="36241">Radiation (non ionising)</asp:ListItem>
                                        <asp:ListItem Value="36238">Radiaton (ionising)</asp:ListItem>
                                        <asp:ListItem Value="36242">Slip or Fall at Same Level</asp:ListItem>
                                        <asp:ListItem Value="36245">Struck Against</asp:ListItem>
                                        <asp:ListItem Value="36243">Struck By</asp:ListItem>
                                        <asp:ListItem Value="36247">Use of Tools / Equipment</asp:ListItem>
                                        <asp:ListItem Value="48581">Vibration</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow ID="A18" HorizontalAlign="Center">
                                <asp:TableCell HorizontalAlign="Center" ColumnSpan="2">
                                    <span id="allspans">
                                    <asp:Table ID="addT" HorizontalAlign="Center" BorderStyle="Double" BorderWidth="4" runat="server">
                                        <asp:TableRow BorderStyle="Double" BorderWidth="2" HorizontalAlign="Center">
                                            <asp:TableCell BorderStyle="Double" BorderWidth="2">&nbsp;</asp:TableCell>
                                            <asp:TableCell BorderStyle="Double" BorderWidth="2" Wrap="false" HorizontalAlign="Center">
                                                <font face="Arial" size="2"><strong>Body Part Affected</strong></font>
                                            </asp:TableCell>
                                            <asp:TableCell BorderStyle="Double" BorderWidth="2" Wrap="false" HorizontalAlign="Center">
                                                <font face="Arial" size="2"><strong>Nature of Illness</strong></font>
                                            </asp:TableCell>
                                        </asp:TableRow >
                                        <asp:TableRow BorderStyle="Double" BorderWidth="2" ID="addR" HorizontalAlign="Center">
                                            <asp:TableCell BorderStyle="Double" BorderWidth="2" ID="c1">
                                                <span id="span1"> &nbsp; </span>
                                            </asp:TableCell>
                                            <asp:TableCell BorderStyle="Double" BorderWidth="2" HorizontalAlign="Left" ID="c2">
                                                <asp:DropDownList ID="strBodyPart_" Width="220" runat="server">
                                                    <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                                    <asp:ListItem Value="36191">Abdomen</asp:ListItem>
                                                    <asp:ListItem Value="36197">Ankle</asp:ListItem>
                                                    <asp:ListItem Value="36189">Back</asp:ListItem>
                                                    <asp:ListItem Value="36202">Buttocks</asp:ListItem>
                                                    <asp:ListItem Value="48263">Cardiovascular</asp:ListItem>
                                                    <asp:ListItem Value="36190">Chest</asp:ListItem>
                                                    <asp:ListItem Value="36175">Ears</asp:ListItem>
                                                    <asp:ListItem Value="36183">Elbow</asp:ListItem>
                                                    <asp:ListItem Value="36174">Eyes</asp:ListItem>
                                                    <asp:ListItem Value="199217">Face</asp:ListItem>
                                                    <asp:ListItem Value="36187">Fingers</asp:ListItem>
                                                    <asp:ListItem Value="36198">Foot</asp:ListItem>
                                                    <asp:ListItem Value="36184">Forearm</asp:ListItem>
                                                    <asp:ListItem Value="48262">Gastro-Intestinal Tract</asp:ListItem>
                                                    <asp:ListItem Value="48261">Genito-Urinary Tract</asp:ListItem>
                                                    <asp:ListItem Value="36192">Groin</asp:ListItem>
                                                    <asp:ListItem Value="48260">Haemopoetic</asp:ListItem>
                                                    <asp:ListItem Value="36186">Hand</asp:ListItem>
                                                    <asp:ListItem Value="36178">Head</asp:ListItem>
                                                    <asp:ListItem Value="36193">Hip</asp:ListItem>
                                                    <asp:ListItem Value="36195">Knee</asp:ListItem>
                                                    <asp:ListItem Value="36196">Lower leg</asp:ListItem>
                                                    <asp:ListItem Value="584880">Lungs</asp:ListItem>
                                                    <asp:ListItem Value="36176">Mouth or Teeth</asp:ListItem>
                                                    <asp:ListItem Value="36177">Neck</asp:ListItem>
                                                    <asp:ListItem Value="73613">None</asp:ListItem>
                                                    <asp:ListItem Value="36179">Nose</asp:ListItem>
                                                    <asp:ListItem Value="36200">Respiratory Tract</asp:ListItem>
                                                    <asp:ListItem Value="584882">Ribs</asp:ListItem>
                                                    <asp:ListItem Value="36173">Scalp</asp:ListItem>
                                                    <asp:ListItem Value="36181">Shoulder</asp:ListItem>
                                                    <asp:ListItem Value="36188">Skin</asp:ListItem>
                                                    <asp:ListItem Value="36194">Thigh</asp:ListItem>
                                                    <asp:ListItem Value="36199">Toes</asp:ListItem>
                                                    <asp:ListItem Value="36182">Upper Arm</asp:ListItem>
                                                    <asp:ListItem Value="36185">Wrist</asp:ListItem>
                                                </asp:DropDownList>
                                            </asp:TableCell>
                                            <asp:TableCell BorderStyle="Double" BorderWidth="2" HorizontalAlign="Left" ID="c3">
                                                <asp:DropDownList ID="strNatureOfInjury_" Width="300" runat="server">
                                                    <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                                    <asp:ListItem Value="36411">Abrasion</asp:ListItem>
                                                    <asp:ListItem Value="36412">Amputation</asp:ListItem>
                                                    <asp:ListItem Value="36415">Asphyxiation</asp:ListItem>
                                                    <asp:ListItem Value="36413">Avulsion</asp:ListItem>
                                                    <asp:ListItem Value="36414">Bite</asp:ListItem>
                                                    <asp:ListItem Value="53180">Blister</asp:ListItem>
                                                    <asp:ListItem Value="36416">Burn - chemical</asp:ListItem>
                                                    <asp:ListItem Value="36417">Burn - thermal</asp:ListItem>
                                                    <asp:ListItem Value="36426">Cancer &amp; Malignant Blood Disorders</asp:ListItem>
                                                    <asp:ListItem Value="53181">Carpal Tunnel Syndrome</asp:ListItem>
                                                    <asp:ListItem Value="36443">Cold Related Injury</asp:ListItem>
                                                    <asp:ListItem Value="36418">Concussion</asp:ListItem>
                                                    <asp:ListItem Value="36419">Contusion/Bruise</asp:ListItem>
                                                    <asp:ListItem Value="36434">Death</asp:ListItem>
                                                    <asp:ListItem Value="36420">Dislocation</asp:ListItem>
                                                    <asp:ListItem Value="36441">Disorder due to Repeated, Cumulative Trauma</asp:ListItem>
                                                    <asp:ListItem Value="36422">Fracture</asp:ListItem>
                                                    <asp:ListItem Value="36433">Hearing Loss</asp:ListItem>
                                                    <asp:ListItem Value="36444">Heat Related Injury</asp:ListItem>
                                                    <asp:ListItem Value="36423">Hernia</asp:ListItem>
                                                    <asp:ListItem Value="36424">Infectious Disease (Infective agents in Workplace)</asp:ListItem>
                                                    <asp:ListItem Value="36427">Laceration/Cut</asp:ListItem>
                                                    <asp:ListItem Value="36429">No Apparent Injury</asp:ListItem>
                                                    <asp:ListItem Value="36432">Other</asp:ListItem>
                                                    <asp:ListItem Value="36425">Penetrating Wound</asp:ListItem>
                                                    <asp:ListItem Value="73640">Physical Assault</asp:ListItem>
                                                    <asp:ListItem Value="36439">Poisoning</asp:ListItem>
                                                    <asp:ListItem Value="36438">Respiratory Condition</asp:ListItem>
                                                    <asp:ListItem Value="73641">Sexual Assault</asp:ListItem>
                                                    <asp:ListItem Value="36436">Skin Disease or Disorder</asp:ListItem>
                                                    <asp:ListItem Value="36431">Sprain or Strain</asp:ListItem>
                                                    <asp:ListItem Value="73639">Stabbed</asp:ListItem>
                                                    <asp:ListItem Value="36442">Standard Threshold Shift(Hearing Loss)</asp:ListItem>
                                                    <asp:ListItem Value="36437">Tinnitus</asp:ListItem>
                                                </asp:DropDownList>
                                                <input type="hidden" value="N" name="strPPE_" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell BorderStyle="Double" BorderWidth="2" HorizontalAlign="Left" ColumnSpan="4">
                                                <input onclick="addRow1();" type="button" value="Add" /><font face="Arial" size="2">&nbsp;&nbsp;Multiple
                                                injury/illnesses</font>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                    </span>
                                    <input type="hidden" value="1" name="strCounter_" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow >
                    <asp:TableCell VerticalAlign="Top" HorizontalAlign="Center" Width="100%" BackColor="#b7e1b2">
                        <asp:Table ID="Table4" Width="100%" HorizontalAlign="Center" BorderWidth="0" runat="server">
                            <asp:TableRow>
                                <asp:TableCell HorizontalAlign="Right">
                                    <script language="javascript">

                                        nextRow = 2;

                                        numRowCount1 = 2;

                                        numRowCount1--;

                                </script>
                                    <font face="Arial" size="2">Number of Days Away From Work:</font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strdaysaway_" MaxLength="5" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2">Number of Days Restricted/Job Transfer:</font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strdaysrestricted_" MaxLength="5" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2"><u>Trauma Counseling?:</u></font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left">
                                    <asp:DropDownList ID="strCounseling_" Width="50" runat="server">
                                        <asp:ListItem Value="N" Selected="True">No</asp:ListItem>
                                        <asp:ListItem Value="Y">Yes</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow >
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2"><u>Medic Comments:</u></font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left" >
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strmediccomments_" MaxLength="200" Width="400" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow >
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2"><u>Medic Name:</u></font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left">
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strmedicname_" MaxLength="100" Width="400" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2"><u>Medic Address:</u></font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left" >
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strmedicaddress_" MaxLength="150" Width="400" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2">Hospital Attended?:</font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left">
                                    <asp:DropDownList ID="strHospital_" Width="50" runat="server">
                                        <asp:ListItem Value="N" Selected="True">No</asp:ListItem>
                                        <asp:ListItem Value="Y">Yes</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow >
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2">Hospital Name and Address:</font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left" >
                                    <font face="Arial" size="2">
                                    <asp:TextBox ID="strhospitalname_" MaxLength="150" Width="400" runat="server"></asp:TextBox>
                                    </font>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow >
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2">Incident Function:</font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left" >
                                    <asp:DropDownList ID="strIncidentFunction_" Width="300" runat="server">
                                        <asp:ListItem Value="-1" Selected="True">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="36352">Construction</asp:ListItem>
                                        <asp:ListItem Value="36353">Drilling and Wells</asp:ListItem>
                                        <asp:ListItem Value="36354">Fab Yds &amp; Construction</asp:ListItem>
                                        <asp:ListItem Value="36355">Other</asp:ListItem>
                                        <asp:ListItem Value="36356">Production and Maintenance</asp:ListItem>
                                    </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow >
                                <asp:TableCell HorizontalAlign="Right">
                                    <font face="Arial" size="2"><strong>Not Used</strong></font>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Left" >
                                    <asp:ListBox SelectionMode="Multiple" ID="ListBox1" Width="140" runat="server">
                                        <asp:ListItem Value="-1">- Needs Data -</asp:ListItem>
                                        <asp:ListItem Value="IR">IR</asp:ListItem>
                                        <asp:ListItem Value="ASA">ASA</asp:ListItem>
                                        <asp:ListItem Value="AUDIT">AUDIT</asp:ListItem>
                                        <asp:ListItem Value="HAZOPS">HAZOPS</asp:ListItem>
                                        <asp:ListItem Value="OTHER EVENT">OTHER EVENT</asp:ListItem>
                                    </asp:ListBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow >
                                <asp:TableCell >
                                &nbsp;
                            </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Right" >
                                    <asp:CheckBox ID="strAnother_" Text="Add Another Illness" runat="server" />
                                    <input type="hidden" value="11577~;3~1~2893125~1~N!12701~;2;3~1~2893125!11461~;2;3~1~2893125!10067~;2;3~1~2893125!10066~~1~2893125!50016~1~1~~1~2893125!" name="strSwitch_" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow >
                    <asp:TableCell VerticalAlign="Top" HorizontalAlign="Center" Width="110%" BackColor="#c0c0c0" BorderWidth="2">
                        <asp:Table ID="Table5" Width="100%" HorizontalAlign="Center" BorderWidth="0" runat="server">
                            <asp:TableRow>
                                <asp:TableCell BackColor="#b7e1b2" HorizontalAlign="Center" VerticalAlign="top">
                                    <input language="JavaScript" onclick="Display_Help2();" type="button" value="Help" />
                                    &nbsp;
                                    <input language="JavaScript" onclick="Cancel_Edit();" type="button" value="Cancel" />
                                    &nbsp;
                                    <input language="JavaScript" onclick="Previous_Screen();" type="button" value="< Previous" />
                                    &nbsp;
                                    <input language="JavaScript" onclick="Verify_Data();" type="button" value="Next >" />

                                &nbsp;

                            </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
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

        function Close_Window()

        { location.href = "HSE_IRI_Common.Remove_IR?strID_=2893125" }

        function Back_Screen()

        { location.href = "http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_IRI_Injury_Illness.Display_Screen?strFlags_=;3&strMode_=1&StrID_=2893125&strInjuryID_=1&strIIType_=N&strSwitch_=12701~;2;3~1~2893125!11461~;2;3~1~2893125!10067~;2;3~1~2893125!10066~~1~2893125!50016~1~1~~1~2893125!" }

        function Display_Help2() {

            window.open('http://traction.bpweb.bp.com/traction/general_help/traction.htm', 'helpwin', 'toolbar=0,scrollbars=yes,menubar=0,status=0,width=650,height=400');

        }

        function IsNumber(textValue) {

            var newLength = textValue.length;

            var newValue = textValue;

            var decimal;

            if (textValue.substring(0, 1) == "-" && newLength > 1) {

                newValue = textValue.substr(1, newLength - 1);

                newLength = newValue.length;

            }

            decimal = newValue.indexOf(".", 0);

            if (decimal != -1)

                if (newValue.indexOf(".", decimal + 1) != -1)

                return false;

            else if (newLength == 1)

                return false;

            for (var i = 0; i != newLength; i++) {

                aChar = newValue.substring(i, i + 1);

                if ((aChar < "0" || aChar > "9") && (aChar != ".")) {

                    return false;

                }

            }

            return true;

        }

        function Check_Length(strField_, strSize_, strEvent_) {

            var FromEvent = strEvent_;

            if (FromEvent == "B") {

                if (strField_.value.length > strSize_) {

                    alert('The maximum length for this field is ' + strSize_);

                    strField_.focus();

                    return false;

                }

            }

            else {

                if (strField_.value.length >= strSize_) {

                    alert('The maximum length for this field is ' + strSize_);

                    strField_.focus();

                    return false;

                }

            }

            return true;

        }

        function Verify_Data() {


            if (!IsNumber(EditForm.strcontinuousdays_.value)) {

                alert("You must enter a valid number.");

                EditForm.strcontinuousdays_.select();

                EditForm.strcontinuousdays_.focus();

                return false;

            }

            if (!IsNumber(EditForm.strdaysaway_.value)) {

                alert("You must enter a valid number.");

                EditForm.strdaysaway_.select();

                EditForm.strdaysaway_.focus();

                return false;

            }

            if (!IsNumber(EditForm.strdaysrestricted_.value)) {

                alert("You must enter a valid number.");

                EditForm.strdaysrestricted_.select();

                EditForm.strdaysrestricted_.focus();

                return false;

            }

            var cb = document.getElementById('strAnother_');

            if (cb.checked == true) {
                pagecount++;
                window.location = "Illness.aspx?pc=" + pagecount.toString();
            }
            else
                window.location = "ARM.aspx";
            //EditForm.submit();

        }

        function Display_Help() {

            window.open('http://traction.testweb.bp.com/traction/help.htm', 'helpwin', 'toolbar=0,menubar=0,status=0,scrollbars=yes,width=650,height=400');

        }

        function Display_Form_Help() {

            window.open('http://traction.testweb.bp.com/traction/help_responsible_asset.htm', 'helpwin', 'toolbar=0,menubar=0,scrollbars=yes,status=0,width=650,height=400');

        }

        function Delete_Record() {

            var closeit = false;

            closeit = confirm("Are you sure you want to delete this record?");

            if (closeit)

            { location.href = "http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_IR_EXPLORER.DELETE_RECORD?strID_=2893125&strSubID_=2&strTypeID_=3&strTableName_=IR_INJURY_ILLNESS_VEW&strFieldName_=InjurID" }

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

//--></script>
    <form name="PreviousForm" action="http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_IRI_Injury_Illness.Display_Screen" method="post">
        <input type="hidden" value=;3 name=strFlags_ />
        <input type="hidden" value="1" name="strMode_" />
        <input type="hidden" value="2893125" name="StrID_" />
        <input type="hidden" value="1" name="strInjuryID_" />
        <input type="hidden" value="N" name="strIIType_" />
        <input type="hidden" value="12701~;2;3~1~2893125!11461~;2;3~1~2893125!10067~;2;3~1~2893125!10066~~1~2893125!50016~1~1~~1~2893125!" name="strSwitch_" />
    </form>
    <script language="Javascript"> <!--

        function Previous_Screen()

        { window.location = "Injury.aspx"; }

        function checkSubmit() {

            if (window.event.keyCode == 0)

                return false;

        }

        document.EditForm.onsubmit = checkSubmit;
//--></script>
    <meta http-equiv="PRAGMA" content="NO-CACHE" />
    <meta http-equiv="Expires" content="-1" />
</body>
</html>
