<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>

<head>

    <title>Incident Report Interviewer - Illness</title>

    <style>

        <!

        -- A

        {

            text-decoration: none;

        }

        A:visited

        {

            color: BLUE;

            text-decoration: none;

        }

        A.MO

        {

            text-decoration: underline;

        }

        A.MO:visited

        {

            text-decoration: underline;

        }

        -- ></style>

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
    <script lanugage="javascript">

        strLastRow = '<asp:TableRow><asp:TableCell ColumnSpan="4" HorizontalAlign="left">'

        strLastRow += '<input type="button" value="Add" onclick="addRow();">'

        strLastRow += '<FONT FACE="Arial" SIZE="2">&nbsp;&nbsp;Multiple injury/illnesses</FONT></asp:TableCell></asp:TableRow></asp:Table>';

        function addRow() {

            objSpanObject = eval('document.all.allspans');

            strTemp = '<SPAN id=span' + nextRow + '><asp:TableRow><asp:TableCell><input type="button" value="Delete" onclick="deleteRow(' + nextRow + ');"></asp:TableRow><asp:TableCell align="left"><SELECT NAME="strBodyPart_" SIZE="1"><OPTION value="-1">- Needs Data -<OPTION value="36191">Abdomen<OPTION value="36197">Ankle<OPTION value="36189">Back<OPTION value="36202">Buttocks<OPTION value="48263">Cardiovascular<OPTION value="36190">Chest<OPTION value="36175">Ears<OPTION value="36183">Elbow<OPTION value="36174">Eyes<OPTION value="199217">Face<OPTION value="36187">Fingers<OPTION value="36198">Foot<OPTION value="36184">Forearm<OPTION value="48262">Gastro-Intestinal Tract<OPTION value="48261">Genito-Urinary Tract<OPTION value="36192">Groin<OPTION value="48260">Haemopoetic<OPTION value="36186">Hand<OPTION value="36178">Head<OPTION value="36193">Hip<OPTION value="36195">Knee<OPTION value="36196">Lower leg<OPTION value="584880">Lungs<OPTION value="36176">Mouth or Teeth<OPTION value="36177">Neck<OPTION value="73613">None<OPTION value="36179">Nose<OPTION value="36200">Respiratory Tract<OPTION value="584882">Ribs<OPTION value="36173">Scalp<OPTION value="36181">Shoulder<OPTION value="36188">Skin<OPTION value="36194">Thigh<OPTION value="36199">Toes<OPTION value="36182">Upper Arm<OPTION value="36185">Wrist</select></asp:TableRow><asp:TableCell align="LEFT"><SELECT NAME="strNatureOfInjury_" SIZE="1"><OPTION value="-1">- Needs Data -<OPTION value="36412">Amputation<OPTION value="36415">Asphyxiation<OPTION value="36416">Burn - chemical<OPTION value="36417">Burn - thermal<OPTION value="36426">Cancer & Malignant Blood Disorders<OPTION value="36418">Concussion<OPTION value="36419">Contusion/Bruise<OPTION value="36434">Death<OPTION value="36420">Dislocation<OPTION value="36441">Disorder due to Repeated, Cumulative Trauma<OPTION value="36422">Fracture<OPTION value="36433">Hearing Loss<OPTION value="36444">Heat Related Injury<OPTION value="36423">Hernia<OPTION value="36427">Laceration/Cut<OPTION value="36428">Loss of  Consciousness <OPTION value="199224">Needlestick or Sharps Injuries<OPTION value="36429">No Apparent Injury<OPTION value="36432">Other<OPTION value="36421">Other Diseases & Disorders<OPTION value="73640">Physical Assault<OPTION value="36439">Poisoning<OPTION value="36438">Respiratory Condition <OPTION value="73641">Sexual Assault<OPTION value="73638">Shot<OPTION value="36436">Skin Disease or Disorder<OPTION value="36431">Sprain or Strain</select></asp:TableRow><INPUT TYPE="hidden" NAME="strPPE_" VALUE="N"><INPUT TYPE="hidden" NAME="strCounter_" VALUE="' + nextRow + '"></span>';

            objSpanObject.innerHTML = objSpanObject.innerHTML.substr(0, objSpanObject.innerHTML.length - strLastRow.length + 2) + strTemp + strLastRow;

            nextRow++;

            numRowCount1++;

 

        }

 

        function addRow1() {

 

 

            var tr = document.getElementById("addR");

            var x = document.getElementById('addT').insertRow(2);

            var y = x.insertCell(0);

            var z = x.insertCell(1);

            var a = x.insertCell(2);

            y.innerHTML = "<input type='button' value='Delete' onclick='deleteRow();'>"

            z.innerHTML = document.getElementById('c2').innerHTML

            a.innerHTML = document.getElementById('c3').innerHTML 

 

        }

        function deleteRow(numID_) {

            objDelSpan = eval('document.all.allspans');

            strTemp = objDelSpan.innerHTML;

            startX = strTemp.indexOf('<SPAN id=span' + numID_);

            endX = strTemp.indexOf('</SPAN>', startX);

            objDelSpan.innerHTML = strTemp.substr(0, startX) + strTemp.substr(endX + 7);

            numRowCount1--;

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

            window.open("http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_Popup_Calendar.Display_Screen?strDestField_=" + dateField_.name + "&strDestForm_=" + dateField_.form.name, "subWindow", "resizable=0,toolbar=0,menubar=0,status=1,width=300,height=300,top=" + (screen.height - 300) / 2 + " ,left=" + (screen.width - 300) / 2);

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

<body bgcolor="white" onload="startSessionTimer();focus_first_field();">

    <script language="Javascript" src="http://brcirsa1n.amoco.com:7790/oratraqajs/overlibMini.js"> <!--

//--></script>

    <iframe id="ifrmCover" style="display: none; left: 0px; position: absolute; top: 0px"

        src="#" frameborder="0" scrolling="no" bgcolor="#000000";"></iframe>

    <basefont face="Arial" size="2" />

    <center>

        <form name="EditForm" action="http://brcirsa1n.amoco.com:7790/pls/oratraqa/HSE_IRI_Injury_Illness.Save_Record1"

        method="post">

        <input type="hidden" name="strFlags_" />

        <input type="hidden" value="2893125" name="strID_" />

        <input type="hidden" value="1" name="strMode_" />

        <input type="hidden" value="2" name="strInjuryID_" />

        <input type="hidden" value="Y" name="strPersonalInfo_" />

        <input type="hidden" value="L" name="strIIFlag_" />

        <input type="hidden" value="402731" name="numSDBUID_" />

        <asp:Table ID="Table1" BackColor="#c0c0c0" BorderWidth="1" runat="server">

            <asp:TableRow>

                <asp:TableCell Width="100%" BackColor="#b7e1b2">

                    <asp:Table ID="Table2" runat="server" CellSpacing="0" CellPadding="0" Width="100%" BackColor="#b7e1b2" BorderWidth="0">

                        <asp:TableRow>

                            <asp:TableCell Width="99%" BackColor="#2d4b9f" HorizontalAlign="Left">

                                <font face="Arial" color="#ffffff" size="2"><strong>Incident Report Interviewer - Illness</strong></font>

                            </asp:TableCell>

                            <asp:TableCell HorizontalAlign="Right" Width="1%" BackColor="#2d4b9f">

                                <a href="javascript:Cancel_Edit();"><img src="http://brcirsa1n.amoco.com:7790/oratraqaimages/close.gif" border="0" /></a>

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

                                <font face="Arial" size="2"><strong>Please enter information for person 1.</strong></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell Wrap="false" HorizontalAlign="Left" ColumnSpan="2">

                                <font face="Arial" size="2"><strong>&nbsp;</strong></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow ID="A1" HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                <font face="Arial" size="2"><u><a class="MO" onmousemove="return DisplayLIB('The name of the individual involved. In some areas Given name is referred to as First Name and Family name is referred to as Last or Surname.',A1)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);">Given

                                            Name:</a></u></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                            <input type="text" maxlength="75" size="50" name="strgivenname_" /></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                <font face="Arial" size="2"><u>Middle Name:</u></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                            <input type="text" maxlength="75" size="50" name="strmiddlename_" /></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><a class="MO" onmousemove="return DisplayLIB('The name of the individual involved. In some areas Given name is referred to as First Name and Family name is referred to as Last or Surname.',A1)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);">Family

                                            Name:</a></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                            <input type="text" maxlength="20" size="20" name="strfamilyname_" /></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><u>Date of Birth (DD/MM/YYYY):</u></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                <input onblur="validateDate(this);" type="text" maxlength="12" size="12" name="strdob_" />

                                </font><a href="javascript:openCalendar(document.EditForm.strdob_);"><img alt="Open Calendar" src="http://brcirsa1n.amoco.com:7790/oratraqaimages/nav_calendar.gif" align="absBottom" border="0" /> </a>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><u>Address:</u></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                            <input type="text" maxlength="200" size="60" name="straddress_" /></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><u>Employee Number:</u></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                            <input type="text" maxlength="30" size="20" name="stremployeenumber_" /></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow id="A2" HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><a class="MO" onmousemove="return DisplayLIB('U.S. enter SSN;  UK enter Social Insurance Number; etc.',A2)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);">National

                                            ID No.:</a></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                            <input type="text" maxlength="30" size="20" name="strssn_" /></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2">Gender:</font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strSex_">

                                <option value="M">Male<option value="F" selected="selected">Female</option>

                                </option>

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2">Occupation:</font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strOccupation_">

                                    <option value="-1" selected="selected">- Needs Data -</option>

                                    <option value="419493">Chemical User</option>

                                    <option value="403334">occ 1</option>

                                    <option value="403335">occ 2</option>

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2">Experience:</font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strExperience_">

                                    <option value="-1" selected="selected">- Needs Data -</option>

                                    <option value="1">&lt; 1 year</option>

                                    <option value="2">1-4 years</option>

                                    <option value="3">5-9 years</option>

                                    <option value="4">10-14 years</option>

                                    <option value="5">15-19 years</option>

                                    <option value="6">20-24 years</option>

                                    <option value="7">25-29 years</option>

                                    <option value="8">30-34 years</option>

                                    <option value="9">35 and over years</option>

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2">Location Type:</font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strLocationType_">

                                    <option value="-1" selected="selected">- Needs Data -</option>

                                    <option value="3">Company Premises</option>

                                    <option value="4">Company Vehicle</option>

                                    <option value="2">Offshore</option>

                                    <option value="48411">Other</option>

                                    <option value="5">Retail Site</option>

                                    <option value="1">Ship</option>

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2">Continuous Days Worked:</font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <font face="Arial" size="2">

                                <input type="text" maxlength="10" size="8" name="strcontinuousdays_" /></font>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><strong>Worker Type:</strong></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strWorkerType_">

                                    <option value="-1" selected="selected">- Needs Data -</option>

                                    <option value="1">BP</option>

                                    <option value="2">Contractor</option>

                                    <option value="3">Third Party</option>

                               </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><strong>Company:</strong></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                 <select size="1" name="strCompany_">

                                    <option value="-1" selected="selected">- Needs Data -</option>

                                    <option value="2148843">Aral</option>

                                    <option value="419490">Aral</option>

                                    <option value="579201">Aramark</option>

                                    <option value="579204">Aramark Vending</option>

                                    <option value="579212">Arscott Cars</option>

                                    <option value="579198">BP (Non Stream)</option>

                                    <option value="419492">Bitumen</option>

                                    <option value="419488">British Gas</option>

                                    <option value="579221">Carlson Wagonlit</option>

                                    <option value="579202">Catalyst Graphics</option>

                                    <option value="2149465">Company3</option>

                                    <option value="579223">EDS</option>

                                    <option value="579233">Fujitsu</option>

                                    <option value="579224">Geoquest</option>

                                    <option value="579232">Getronics</option>

                                    <option value="419487">Hays</option>

                                    <option value="579230">IBM</option>

                                    <option value="579203">ISS Cleaning</option>

                                    <option value="579196">Interior</option>

                                    <option value="579199">Iron Mountain/BDM</option>

                                    <option value="579200">Johnson Controls</option>

                                    <option value="579225">Kaleidoscope</option>

                                    <option value="579213">Kinderquest</option>

                                    <option value="579205">Lancaster Cleaning</option>

                                    <option value="579214">Leisure Connection</option>

                                    <option value="579222">Love &amp; Tate</option>

                                    <option value="579206">M &amp; A Plants</option>

                                    <option value="579215">MCH Buses</option>

                                    <option value="579216">Mitie</option>

                                    <option value="579207">Norland Managed Services</option>

                                    <option value="579208">Oce</option>

                                    <option value="579197">Overbury</option>

                                    <option value="419491">P&amp;O</option>

                                    <option value="579226">Phoenix</option>

                                    <option value="579209">Pitney Bowes Management Services</option>

                                    <option value="579210">Resolution</option>

                                    <option value="579231">SAIC</option>

                                    <option value="579229">Securiplan</option>

                                    <option value="579219">Select Appointments</option>

                                    <option value="579220">Strata</option>

                                    <option value="579227">Syncordia</option>

                                    <option value="1011978">Test</option>

                                    <option value="579217">Waterers Landscape</option>

                                    <option value="579211">William Lea</option>

                                    <option value="579218">Wilson-James</option>

                                    <option value="579228">Worldcom</option>

                                    <option value="419489">bbb</option>

                                    <option value="419484">clog</option>

                                    <option value="403320">company 1</option>

                                    <option value="403321">company 2</option>

                                    <option value="2148955">deepa</option>

                                    <option value="419486">motherwell bridge</option>

                                    <option value="419485">tankfreight</option>

                                    <option value="419483">zipper</option>                                                                                                                                                                                                                  

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><strong>Classification:</strong></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strClassification_">

                                    <option value="-1" selected="selected">- Needs Data -</option>

                                    <option value="1">Not Job Related</option>

                                    <option value="2">No Treatment</option>

                                    <option value="4">First Aid</option>

                                    <option value="5">Medical Treatment</option>

                                    <option value="6">Restricted Work / Job Transfer</option>

                                    <option value="8">Days Away From Work</option>

                                    <option value="9">Workforce Fatality</option>

                                    <option value="489079">3rd Party Fatality - Material Influence</option>

                                    <option value="489080">3rd Party Fatality - No Material Influence</option>

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><a class="MO" onmousemove="return DisplayLIB('<b>Primary care:</b> First line care given following an incident, for instance an x ray to exclude injury and application of a bandage.<br><b>Secondary care:</b> Follow up care, for instance if an individual had to return for a further appointment the next day to check a dressing etc.<br><b>Tertiary care:</b> Ongoing care which could be for weeks or days, for instance physio following an incident.<br><b>Medevacuation:</b> When an ill or injured person is transferred to another location for continuing treatment. This can include transfer from original scene of incident  to more advanced health care facilities, or secondary transfer from health care setting in one country to alternative health care location in another country.<br><b>Medrescue:</b> Emergency medical rescue services for  individuals involved in an incident at a remote location to take them to nearest health care.On Site  Any care given while still at  main location, not requiring any further referral to offsite support.<br><b>On Site:</b> refers to any case where care given while the injured party is still at the BP Site not requiring any further referral to offsite support.',A3)" tabindex="1000" onmouseout="nd();" href="javascript:void(0);">Treatment:</a></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strTreatment_">

                                    <option value="-1" selected="selected">- Needs Data -</option>

                                    <option value="2">Medivac</option>

                                    <option value="3">Medrescue</option>

                                    <option value="71536">No Treatment</option>

                                    <option value="1">On-Site</option>

                                    <option value="4">Primary Care</option>

                                    <option value="48487">Secondary Care</option>

                                    <option value="48488">Tertiary Care</option>

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign = "Right">

                                 <font face="Arial" size="2"><strong>Type of Contact:</strong></font>

                            </asp:TableCell>

                            <asp:TableCell Wrap="false" HorizontalAlign="Left">

                                <select size="1" name="strContact_">

                                    <option value="-1" selected="selected">- Needs Data -e</option>

                                    <option value="48582">Biological Agentse</option>

                                    <option value="36244">Buriede</option>

                                    <option value="36226">Caught In, Under or Betweene</option>

                                    <option value="48585">Chemical Duste</option>

                                    <option value="36227">Chemical Liquide</option>

                                    <option value="36235">Cold Substances (burns)e</option>

                                    <option value="36228">Cold Surfaces (burns)e</option>

                                    <option value="73637">Criminal Incidente</option>

                                    <option value="36229">Diving Relatede</option>

                                    <option value="48583">Duste</option>

                                    <option value="36230">Electricitye</option>

                                    <option value="36246">Ergonomicse</option>

                                    <option value="36231">Eyeflashe</option>

                                    <option value="36232">Fall from Heighte</option>

                                    <option value="36233">Fall from Ladder/Stepse</option>

                                    <option value="36234">Fire or Explosione</option>

                                    <option value="36236">Fume / Gas / Vapoure</option>

                                    <option value="48588">Hot Substances(burns)e</option>

                                    <option value="48589">Hot Surfaces (burns)e</option>

                                    <option value="36239">Loss of Containmente</option>

                                    <option value="36240">Machinerye</option>

                                    <option value="36237">Manual Handlinge</option>

                                    <option value="48580">Noisee</option>

                                    <option value="36248">Othere</option>

                                    <option value="48586">Pressure (high)e</option>

                                    <option value="48587">Pressure (lo)e</option>

                                    <option value="48584">Psychosocial Factorse</option>

                                    <option value="36241">Radiation (non ionising)e</option>

                                    <option value="36238">Radiaton (ionising)e</option>

                                    <option value="36242">Slip or Fall at Same Levele</option>

                                    <option value="36245">Struck Againste</option>

                                    <option value="36243">Struck Bye</option>

                                    <option value="36247">Use of Tools / Equipmente</option>

                                    <option value="48581">Vibration</option>

                                </select>

                            </asp:TableCell>

                        </asp:TableRow>

                        <asp:TableRow HorizontalAlign="Center">

                            <asp:TableCell HorizontalAlign="Center" ColumnSpan="2">

                            <span id="allspans">

                                <asp:Table ID="addT" HorizontalAlign="Center" BorderStyle="Double" BorderWidth="1" runat="server">

                                    <asp:TableRow HorizontalAlign="Center">

                                        <asp:TableCell>&nbsp;</asp:TableCell>

                                        <asp:TableCell Wrap="false" HorizontalAlign="Center">

                                            <font face="Arial" size="2"><strong>Body Part Affected</strong></font>

                                        </asp:TableCell>

                                        <asp:TableCell Wrap="false" HorizontalAlign="Center">

                                            <font face="Arial" size="2"><strong>Nature of Illness</strong></font>

                                        </asp:TableCell>                                                              

                                    </asp:TableRow>

                                    <asp:TableRow ID="addR" HorizontalAlign="Center">

                                        <asp:TableCell ID="c1">

                                        <span id="span1">

                                        &nbsp;

                                        </span>

                                        </asp:TableCell>

                                        <asp:TableCell HorizontalAlign="Left" id="c2">

                                            <select size="1" name="strBodyPart_">

                                                <option value="-1" selected="selected">- Needs Data -</option>

                                                <option value="36191">Abdomen</option>

                                                <option value="36197">Ankle</option>

                                                <option value="36189">Back</option>

                                                <option value="36202">Buttocks</option>

                                                <option value="48263">Cardiovascular</option>

                                                <option value="36190">Chest</option>

                                                <option value="36175">Ears</option>

                                                <option value="36183">Elbow</option>

                                                <option value="36174">Eyes</option>

                                                <option value="199217">Face</option>

                                                <option value="36187">Fingers</option>

                                                <option value="36198">Foot</option>

                                                <option value="36184">Forearm</option>

                                                <option value="48262">Gastro-Intestinal Tract</option>

                                                <option value="48261">Genito-Urinary Tract</option>

                                                <option value="36192">Groin</option>

                                                <option value="48260">Haemopoetic</option>

                                                <option value="36186">Hand</option>

                                                <option value="36178">Head</option>

                                                <option value="36193">Hip</option>

                                                <option value="36195">Knee</option>

                                                <option value="36196">Lower leg</option>

                                                <option value="584880">Lungs</option>

                                                <option value="36176">Mouth or Teeth</option>

                                                <option value="36177">Neck</option>

                                                <option value="73613">None</option>

                                                <option value="36179">Nose</option>

                                                <option value="36200">Respiratory Tract</option>

                                                <option value="584882">Ribs</option>

                                                <option value="36173">Scalp</option>

                                                <option value="36181">Shoulder</option>

                                                <option value="36188">Skin</option>

                                                <option value="36194">Thigh</option>

                                                <option value="36199">Toes</option>

                                                <option value="36182">Upper Arm</option>

                                                <option value="36185">Wrist</option>

                                            </select>

                                        </asp:TableCell>

                                        <asp:TableCell HorizontalAlign="Left" id="c3">

                                            <select size="1" name="strNatureOfInjury_">

                                                <option value="-1" selected="selected">- Needs Data -</option>

                                                <option value="36411">Abrasion</option>

                                                <option value="36412">Amputation</option>

                                                <option value="36415">Asphyxiation</option>

                                                <option value="36413">Avulsion</option>

                                                <option value="36414">Bite</option>

                                                <option value="53180">Blister</option>

                                                <option value="36416">Burn - chemical</option>

                                                <option value="36417">Burn - thermal</option>

                                                <option value="36426">Cancer &amp; Malignant Blood Disorders</option>

                                                <option value="53181">Carpal Tunnel Syndrome</option>

                                                <option value="36443">Cold Related Injury</option>

                                                <option value="36418">Concussion</option>

                                                <option value="36419">Contusion/Bruise</option>

                                                <option value="36434">Death</option>

                                                <option value="36420">Dislocation</option>

                                                <option value="36441">Disorder due to Repeated, Cumulative Trauma</option>

                                                <option value="36422">Fracture</option>

                                                <option value="36433">Hearing Loss</option>

                                                <option value="36444">Heat Related Injury</option>

                                                <option value="36423">Hernia</option>

                                                <option value="36424">Infectious Disease (Infective agents in Workplace)</option>

                                                <option value="36427">Laceration/Cut</option>

                                                <option value="36429">No Apparent Injury</option>

                                                <option value="36432">Other</option>

                                                <option value="36425">Penetrating Wound</option>

                                                <option value="73640">Physical Assault</option>

                                                <option value="36439">Poisoning</option>

                                                <option value="36438">Respiratory Condition</option>

                                                <option value="73641">Sexual Assault</option>

                                                <option value="36436">Skin Disease or Disorder</option>

                                                <option value="36431">Sprain or Strain</option>

                                                <option value="73639">Stabbed</option>

                                                <option value="36442">Standard Threshold Shift(Hearing Loss)</option>

                                                <option value="36437">Tinnitus</option>

                                            </select>

                                            <input type="hidden" value="N" name="strPPE_" />

                                        </asp:TableCell>

                                    </asp:TableRow>

                                    <asp:TableRow>

                                    <asp:TableCell HorizontalAlign="Left" ColumnSpan="4">

                                        <input onclick="addRow1();" type="button" value="Add" /><font face="Arial" size="2">&nbsp;&nbsp;Multiple injury/illnesses</font>

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

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <script language="javascript">

                        nextRow = 2;

                        numRowCount1 = 2;

                        numRowCount1--;

                    </script>

                    

                    <font face="Arial" size="2">Number of Days Away From Work:</font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <font face="Arial" size="2">

                    <input type="text" maxlength="5" size="5" name="strdaysaway_" /></font>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2">Number of Days Restricted/Job Transfer:</font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <font face="Arial" size="2">

                    <input type="text" maxlength="5" size="5" name="strdaysrestricted_" /></font>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2"><u>Trauma Counseling?:</u></font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <select size="1" name="strCounseling_">

                        <option value="N" selected="selected">No</option>

                        <option value="Y">Yes</option>

                   </select>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2"><u>Medic Comments:</u></font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <font face="Arial" size="2">

                    <input type="text" maxlength="200" size="75" name="strmediccomments_" /></font>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2"><u>Medic Name:</u></font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <font face="Arial" size="2">

                    <input type="text" maxlength="100" size="75" name="strmedicname_" /></font>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2"><u>Medic Address:</u></font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <font face="Arial" size="2">

                    <input type="text" maxlength="150" size="75" name="strmedicaddress_" /></font>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2">Hospital Attended?:</font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <select size="1" name="strHospital_">

                        <option value="N" selected="selected">No</option>

                        <option value="Y">Yes</option>

                    </select>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2">Hospital Name and Address:</font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <font face="Arial" size="2">

                    <input type="text" maxlength="150" size="75" name="strhospitalname_" /></font>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2">Incident Function:</font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <select size="1" name="strIncidentFunction_">

                        <option value="-1" selected="selected">- Needs Data -</option>

                        <option value="36352">Construction</option>

                        <option value="36353">Drilling and Wells</option>

                        <option value="36354">Fab Yds &amp; Construction</option>

                        <option value="36355">Other</option>

                        <option value="36356">Production and Maintenance</option>

                    </select>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Center">

                <asp:TableCell HorizontalAlign="Right">

                    <font face="Arial" size="2"><strong>Not Used</strong></font>

                </asp:TableCell>

                <asp:TableCell Wrap="false" HorizontalAlign="Left">

                    <select multiple="multiple" size="5" name="strMCustomList1_">

                        <option value="-1">- Needs Data -</option>

                        <option value="IR">IR</option>

                        <option value="ASA">ASA</option>

                        <option value="AUDIT">AUDIT</option>

                        <option value="HAZOPS">HAZOPS</option>

                        <option value="OTHER EVENT">OTHER EVENT</option>

                    </select>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow HorizontalAlign="Right">

                <asp:TableCell HorizontalAlign="Right">

                    &nbsp;

                </asp:TableCell>

                <asp:TableCell HorizontalAlign="Right">

                    <input type="checkbox" value="1" name="strAnother_" /><font face="Arial" size="2">Add Another Illness</font>

                    <input type="hidden" value="11577~;3~1~2893125~1~N!12701~;2;3~1~2893125!11461~;2;3~1~2893125!10067~;2;3~1~2893125!10066~~1~2893125!50016~1~1~~1~2893125!" name="strSwitch_" />

        </asp:Table>

        </asp:TableCell> </asp:TableRow>

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

            if (!IsNumber(document.EditForm.strcontinuousdays_.value)) {

                alert("You must enter a valid number.");

                document.EditForm.strcontinuousdays_.select();

                document.EditForm.strcontinuousdays_.focus();

                return false;

            }

            if (!IsNumber(document.EditForm.strdaysaway_.value)) {

                alert("You must enter a valid number.");

                document.EditForm.strdaysaway_.select();

                document.EditForm.strdaysaway_.focus();

                return false;

            }

            if (!IsNumber(document.EditForm.strdaysrestricted_.value)) {

                alert("You must enter a valid number.");

                document.EditForm.strdaysrestricted_.select();

                document.EditForm.strdaysrestricted_.focus();

                return false;

            }

            document.EditForm.submit();

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

    <input type="hidden" value=";3" name="strFlags_" />

    <input type="hidden" value="1" name="strMode_" />

    <input type="hidden" value="2893125" name="StrID_" />

    <input type="hidden" value="1" name="strInjuryID_" />

    <input type="hidden" value="N" name="strIIType_" />

    <input type="hidden" value="12701~;2;3~1~2893125!11461~;2;3~1~2893125!10067~;2;3~1~2893125!10066~~1~2893125!50016~1~1~~1~2893125!"

        name="strSwitch_" />

    </form>

 

    <script language="Javascript"> <!--

        function Previous_Screen()

        { document.PreviousForm.submit(); }

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