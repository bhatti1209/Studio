<%@ Page Language="C#" MasterPageFile="~/UI/PageDesign.Master" AutoEventWireup="true"
    CodeBehind="Injury.aspx.cs" Inherits="DraftWebPage.UI.IncidentReport.Injury"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DisplayData" runat="server">

    <script type="text/javascript">
        var crow=1;
        var high=100;
        function addRow1() {
            crow++;
            var tr = document.getElementById('allspans');
            var tochar = tr.innerHTML.length - 142;
            var IHM = tr.innerHTML.substr(0, tochar);
            IHM += "<TR ID=ctl00_DisplayData_addR>";
            IHM += "<TD ID=ctl00_DisplayData_c1>";
            IHM += "<input id='crow" + crow + "' type='button' value='Delete' onclick='deleteRow1(" + crow + ");'>";
            IHM += "</TD><TD ID=ctl00_DisplayData_c2>";
            IHM += document.getElementById('ctl00_DisplayData_c2').innerHTML;
            IHM += "</TD><TD ID=ctl00_DisplayData_c3>";
            IHM += document.getElementById('ctl00_DisplayData_c3').innerHTML;
            IHM += "</TD></TR>";
            IHM += "<TR align=left><TD colspan=3><input type=button value=Add onclick=addRow1();>&nbsp;&nbsp;Multiple injury/Illnesses";
            IHM += "</TD></TR></TBODY></TABLE>";

            tr.innerHTML = IHM;
            var p7 = document.getElementById('ctl00_DisplayData_Panel7');
            var st = p7.getAttribute("style");
            high+=25;
            var s1 = st.substr(0,157) + "HEIGHT : " + high + st.substr(168, st.lenght);
            p7.setAttribute("style",s1);
        }
        
        function deleteRow1(rowid) {
            var table = document.getElementById('ctl00_DisplayData_addT');
            var rowCount = table.rows.length;

            for (var i = 2; i < rowCount; i++) {
                var row = table.rows[i];
                var btn = row.cells[0].childNodes[0];
                var nm = "crow" + rowid;
                if (btn.id == nm) {
                    table.deleteRow(i);
                    crow--;
                    i = rowCount + 1;
                    
                    var p7 = document.getElementById('ctl00_DisplayData_Panel7');
                    var st = p7.getAttribute("style");
                    high-=25;
                    var s1 = st.substr(0,157) + "HEIGHT : " + high + st.substr(168, st.lenght);
                    p7.setAttribute("style",s1);
                }
            }
        }
    </script>

    <div style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 499px; width: 745px">
        <asp:Panel ID="Panel1" runat="server" BorderColor="#999999" Style="z-index: 1; left: 7px;
            top: -2px; position: absolute; height: 530px; width: 742px">
            <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 250px; top: 3px; position: absolute;
                height: 16px; width: 500px" Text="Incident Report Interviewer - Injury" Font-Names="Calibri"
                Font-Italic="True" Font-Overline="False" Font-Underline="True" ForeColor="#8AD338"></asp:Label>
            <asp:UpdatePanel ID="TabBrowserUpdatePanel" runat="server">
                <ContentTemplate>
                    <asp:ImageButton TabIndex="40" ID="ImageButton2" runat="server" Style="z-index: 2;
                        left: 292px; top: 32px; position: absolute; width: 187px; height: 30px; margin-right: 0px;"
                        ImageUrl="~/Images/UnSelectedTab2.jpg" OnClick="ImageButton2_Click"></asp:ImageButton>
                    <asp:ImageButton TabIndex="41" ID="ImageButton1" runat="server" ImageUrl="~/Images/SelectedTab2.jpg"
                        Style="z-index: 2; left: 96px; top: 32px; position: absolute; width: 187px; height: 30px;
                        margin-right: 0px;" OnClick="ImageButton1_Click"></asp:ImageButton>
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/BackColor2.jpg" Style="z-index: 1;
                        left: 31px; top: 26px; position: absolute; height: 36px; width: 680px;" />
                    <asp:LinkButton TabIndex="42" ID="LinkButton3" runat="server" Style="z-index: 3;
                        left: 347px; top: 38px; position: absolute; height: 22px; text-decoration: none;
                        width: 95px;" ForeColor="Black" Text="Injury Details" Font-Bold="False" OnClick="LinkButton3_Click"></asp:LinkButton>
                    <asp:LinkButton TabIndex="43" ID="LinkButton2" runat="server" Font-Bold="True" ForeColor="Black"
                        Style="z-index: 3; left: 133px; top: 38px; position: absolute; text-decoration: none;
                        height: 22px; width: 114px;" Text="Personal Details" OnClick="LinkButton2_Click"></asp:LinkButton>
                    <asp:Panel ID="TabBrowserPanel" runat="server" Style="z-index: 1; left: 29px; top: 25px;
                        position: absolute; height: 491px; width: 681px" BorderStyle="Solid" BorderWidth="1px">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Style="z-index: 1; left: 32px;
                            top: 42px; position: absolute; width: 243px" Text="Please Enter Details About Person"></asp:Label>
                        <asp:Label ID="PersonCountLabel" runat="server" Style="z-index: 1; left: 269px; top: 42px;
                            position: absolute; width: 30px" Text="1" Font-Bold="True"></asp:Label>
                        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex=0>
                            <asp:View ID="PersonalDetailsTab" runat="server">
                                <asp:Panel ID="PersonalDetailsPanel" Style="position: absolute; top: 37px; left: 1px;
                                    height: 453px; background-color: #E0F2B5; width: 679px;" runat="server">
                                    <asp:Panel ID="Panel2" runat="server" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1"
                                        Style="z-index: 1; background-color: #EFF3B6; left: 19px; top: 27px; position: absolute;
                                        height: 186px; width: 315px">
                                        <asp:TextBox ID="NationalID" TabIndex="5" runat="server" Style="z-index: 1; left: 137px;
                                            top: 157px; position: absolute"></asp:TextBox>
                                        <asp:TextBox ID="EmployeeName" TabIndex="4" runat="server" Style="z-index: 1; left: 138px;
                                            top: 118px; position: absolute; bottom: 52px;"></asp:TextBox>
                                        <asp:TextBox ID="FamilyName" TabIndex="3" runat="server" Style="z-index: 1; left: 137px;
                                            top: 80px; position: absolute"></asp:TextBox>
                                        <asp:TextBox ID="MiddleName" TabIndex="2" runat="server" Style="z-index: 1; left: 137px;
                                            top: 41px; position: absolute"></asp:TextBox>
                                        <asp:TextBox ID="GivenName" TabIndex="1" runat="server" Style="z-index: 1; left: 137px;
                                            top: 10px; position: absolute"></asp:TextBox>
                                        <a class="ToolText2" onmouseover="javascript:this.className='ToolTextHover2'" onmouseout="javascript:this.className='ToolText2'">
                                            <label id="NationalIDlabel" style="z-index: 1; left: 10px; top: 161px; position: absolute;
                                                color: #000099; width: 104px">
                                                National ID :
                                            </label>
                                            <span>U.S. enter SSN; UK enter Social Insurance Number; etc. </span></a>
                                        <asp:Label ID="EmpNameLabel" runat="server" Style="z-index: 1; left: 10px; top: 119px;
                                            position: absolute; width: 110px" Text="Employee Name :"></asp:Label>
                                        <a class="ToolText2" onmouseover="javascript:this.className='ToolTextHover2'" onmouseout="javascript:this.className='ToolText2'">
                                            <label id="FamilyNameLabel" style="z-index: 1; left: 10px; top: 83px; position: absolute;
                                                color: #000099; width: 104px">
                                                Family Name :
                                            </label>
                                            <span>The name of the individual involved. In some areas Given name is referred to as
                                                First Name and Family name is referred to as Last or Surname. </span></a>
                                        <asp:Label ID="MiddleNameLabel" runat="server" Style="z-index: 1; left: 10px; top: 44px;
                                            position: absolute; width: 104px" Text="Middle Name :"></asp:Label>
                                        <a class="ToolText2" onmouseover="javascript:this.className='ToolTextHover2'" onmouseout="javascript:this.className='ToolText2'">
                                            <label id="GivenNameLabel" style="z-index: 1; left: 10px; top: 10px; position: absolute;
                                                color: #000099; width: 104px">
                                                Given Name :
                                            </label>
                                            <span>The name of the individual involved. In some areas Given name is referred to as
                                                First Name and Family name is referred to as Last or Surname. </span></a>
                                    </asp:Panel>
                                    <asp:Panel ID="Panel3" runat="server" BackColor="#EFF3B6" BorderColor="Silver" BorderStyle="Solid"
                                        BorderWidth="1" Style="z-index: 1; left: 340px; top: 27px; position: absolute;
                                        height: 185px; width: 315px">
                                        <asp:TextBox TabIndex="7" ID="Address" runat="server" Style="z-index: 1; left: 150px;
                                            top: 48px; position: absolute; height: 83px; width: 131px;" TextMode="MultiLine"></asp:TextBox>
                                        <asp:Label ID="GenderLabel" runat="server" Style="z-index: 1; left: 14px; top: 147px;
                                            position: absolute; width: 104px" Text="Gender :"></asp:Label>
                                        <asp:Label ID="AddressLabel" runat="server" Style="z-index: 1; left: 10px; top: 62px;
                                            position: absolute; width: 104px" Text="Address :"></asp:Label>
                                        <asp:Label ID="DOBLabel" runat="server" Style="z-index: 1; left: 10px; top: 10px;
                                            position: absolute; width: 104px" Text="Date Of Birth :"></asp:Label>
                                        <asp:DropDownList TabIndex="8" ID="Gender" runat="server" Style="z-index: 1; left: 150px;
                                            top: 147px; position: absolute; height: 21px; width: 91px">
                                            <asp:ListItem Selected="True">Female</asp:ListItem>
                                            <asp:ListItem>Male</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:UpdatePanel UpdateMode="Conditional" ID="calupdate" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox TabIndex="6" ID="DOB" runat="server" Style="z-index: 1; left: 150px;
                                                    top: 10px; position: absolute; width: 101px;"></asp:TextBox>
                                                <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
                                                    BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
                                                    ForeColor="#663399" OnSelectionChanged="Calendar1_SelectionChanged" Style="z-index: 2;
                                                    left: 212px; top: -22px; position: absolute; height: 164px; width: 211px" Visible="False"
                                                    Height="200px" ShowGridLines="True" Width="220px">
                                                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                                    <SelectorStyle BackColor="#FFCC66" />
                                                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                                    <OtherMonthDayStyle ForeColor="#CC9966" />
                                                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                                    <DayHeaderStyle BackColor="#FFCC66" Height="1px" Font-Bold="True" />
                                                    <TitleStyle BackColor="#8BD6A9" Font-Bold="True" Font-Size="9pt" ForeColor="#332E4B" />
                                                </asp:Calendar>
                                                <asp:ImageButton ID="CalButton" runat="server" ImageUrl="~/Images/cal.gif" Style="z-index: 1;
                                                    left: 264px; top: 13px; position: absolute; height: 16px" OnClick="CalButton_Click" />
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </asp:Panel>
                                    <asp:Panel ID="Panel4" runat="server" BackColor="#EFF3B6" BorderColor="Silver" BorderStyle="Solid"
                                        BorderWidth="1" Style="z-index: 1; left: 19px; top: 219px; position: absolute;
                                        height: 186px; width: 315px">
                                        <asp:Label ID="Companylabel" runat="server" Font-Bold="True" Font-Underline="False"
                                            Style="z-index: 1; left: 10px; top: 157px; position: absolute; width: 104px"
                                            Text="Company :"></asp:Label>
                                        <asp:Label ID="WorkerTypeLabel0" runat="server" Font-Bold="True" Style="z-index: 1;
                                            left: 10px; top: 119px; position: absolute; width: 110px" Text="Worker Type :"></asp:Label>
                                        <asp:Label ID="LocationTypeLabel" runat="server" Font-Underline="False" Style="z-index: 1;
                                            left: 10px; top: 83px; position: absolute; width: 104px" Text="Location Type :"></asp:Label>
                                        <asp:Label ID="ExperienceLabel" runat="server" Style="z-index: 1; left: 10px; top: 44px;
                                            position: absolute; width: 104px" Text="Experience :"></asp:Label>
                                        <asp:Label ID="OccupationLabel" runat="server" Font-Underline="False" Style="z-index: 1;
                                            left: 10px; top: 10px; position: absolute; width: 104px; height: 19px;" Text="Occupation :"></asp:Label>
                                        <asp:DropDownList TabIndex="13" ID="Company" runat="server" Style="z-index: 1; left: 137px;
                                            top: 158px; position: absolute; width: 105px;">
                                        </asp:DropDownList>
                                        <asp:DropDownList TabIndex="12" ID="WorkerType" runat="server" Style="z-index: 1;
                                            left: 137px; top: 121px; position: absolute; width: 105px;">
                                        </asp:DropDownList>
                                        <asp:DropDownList TabIndex="11" ID="LocationType" runat="server" Style="z-index: 1;
                                            left: 137px; top: 84px; position: absolute; width: 105px;">
                                        </asp:DropDownList>
                                        <asp:DropDownList TabIndex="10" ID="Experience" runat="server" Style="z-index: 1;
                                            left: 137px; top: 44px; position: absolute; width: 105px;">
                                        </asp:DropDownList>
                                        <asp:DropDownList TabIndex="9" ID="Occupation" runat="server" Style="z-index: 1;
                                            left: 137px; top: 12px; position: absolute; width: 105px;">
                                        </asp:DropDownList>
                                    </asp:Panel>
                                    <asp:Panel ID="Panel5" runat="server" BackColor="#EFF3B6" BorderColor="Silver" BorderStyle="Solid"
                                        BorderWidth="1" Style="z-index: 1; left: 340px; top: 219px; position: absolute;
                                        height: 186px; width: 315px">
                                        <asp:TextBox TabIndex="14" ID="ContinuesDaysWorked" runat="server" Style="z-index: 1;
                                            left: 178px; top: 20px; position: absolute; bottom: 144px; width: 88px;"></asp:TextBox>
                                        <asp:Label ID="TOCLabel" runat="server" Style="z-index: 1; left: 11px; top: 138px;
                                            position: absolute;" Text="Type Of Contact :" Font-Bold="True"></asp:Label>
                                        <a class="ToolText2" onmouseover="javascript:this.className='ToolTextHover2'" onmouseout="javascript:this.className='ToolText2'">
                                            <label id="TreatmentLabel" style="z-index: 1; color: #000099; left: 14px; top: 99px;
                                                position: absolute; width: 104px">
                                                Treatment :
                                            </label>
                                            <span><b>Primary care:</b> First line care given following an incident, for instance
                                                an x ray to exclude injury and application of a bandage.<br>
                                                <b>Secondary care:</b> Follow up care, for instance if an individual had to return
                                                for a further appointment the next day to check a dressing etc.<br>
                                                <b>Tertiary care:</b> Ongoing care which could be for weeks or days, for instance
                                                physio following an incident.<br>
                                                <b>Medevacuation:</b> When an ill or injured person is transferred to another location
                                                for continuing treatment. This can include transfer from original scene of incident
                                                to more advanced health care facilities, or secondary transfer from health care
                                                setting in one country to alternative health care location in another country.<br>
                                                <b>Medrescue:</b> Emergency medical rescue services for individuals involved in
                                                an incident at a remote location to take them to nearest health care.On Site Any
                                                care given while still at main location, not requiring any further referral to offsite
                                                support.<br>
                                                <b>On Site:</b> refers to any case where care given while the injured party is still
                                                at the BP Site not requiring any further referral to offsite support. </span>
                                        </a>
                                        <asp:Label ID="ClassificationLabel" runat="server" Style="z-index: 1; left: 11px;
                                            top: 61px; position: absolute; width: 104px" Text="Classification :" Font-Bold="True"></asp:Label>
                                        <asp:Label ID="CWDLabel" runat="server" Style="z-index: 1; left: 10px; top: 21px;
                                            position: absolute; width: 157px; height: 19px;" Text="Continues Days Worked :"
                                            Font-Underline="False"></asp:Label>
                                        <asp:DropDownList TabIndex="17" ID="TypeOfContact" runat="server" Style="z-index: 1;
                                            left: 150px; top: 139px; position: absolute; width: 105px;">
                                        </asp:DropDownList>
                                        <asp:DropDownList TabIndex="16" ID="Treatment" runat="server" Style="z-index: 1;
                                            left: 150px; top: 103px; position: absolute; width: 105px;">
                                        </asp:DropDownList>
                                        <asp:DropDownList TabIndex="15" ID="Classification" runat="server" Style="z-index: 1;
                                            left: 150px; top: 64px; position: absolute; width: 105px; height: 22px;">
                                        </asp:DropDownList>
                                    </asp:Panel>
                                    <asp:ImageButton ID="NextButton" runat="server" ImageUrl="~/Images/Buttons/FrwdArrow2.jpg"
                                        Style="z-index: 0; left: 520px; top: 410px; position: absolute; height: 44px;
                                        width: 48px" OnClick="NextButton_Click" ToolTip="Next" />
                                    <asp:ImageButton ID="PreviousButton" runat="server" ImageUrl="~/Images/Buttons/BackButton2.jpg"
                                        Style="z-index: 0; left: 100px; top: 410px; position: absolute; height: 44px;
                                        width: 48px" OnClick="PreviousButton_Click" ToolTip="Previous" />
                                    <asp:ImageButton ID="HelpButton" runat="server" ImageUrl="~/Images/Buttons/HelpButton3.jpg"
                                        Style="z-index: 0; left: 250px; top: 410px; position: absolute; height: 44px;
                                        width: 48px" ToolTip="Help !!" />
                                    <asp:ImageButton ID="CancelButton" runat="server" ImageUrl="~/Images/Buttons/CancelButton4.jpg"
                                        Style="z-index: 0; left: 400px; top: 410px; position: absolute; height: 44px;
                                        width: 48px" OnClick="CancelButton_Click" ToolTip="Cancel" />
                                </asp:Panel>
                            </asp:View>
                            <asp:View ID="InjuryDetailsTab" runat="server">
                                <asp:Panel ID="InjuryDetailsPanel" Style="position: absolute; top: 37px; left: 1px;
                                    height: 453px; width: 679px; background-color: #E0F2B5;" runat="server">
                                    <asp:Panel ID="Panel11" runat="server" BackColor="#EFF3B6" BorderColor="Silver" BorderStyle="Solid"
                                        BorderWidth="1" Style="z-index: 1; left: 19px; top: 32px; position: absolute;
                                        height: 250px; width: 637px">
                                        <asp:Label ID="MAddLabel" runat="server" Font-Bold="False" Font-Underline="False"
                                            Style="z-index: 1; left: 9px; top: 193px; position: absolute; width: 104px" Text="Medic Address :"></asp:Label>
                                        <asp:Label ID="MedicCommentLabel" runat="server" Font-Bold="False" Style="z-index: 1;
                                            left: 10px; top: 119px; position: absolute; width: 110px" Text="Medic Comment :"></asp:Label>
                                        <asp:Label ID="HAddLabel" runat="server" Font-Underline="False" Style="z-index: 1;
                                            left: 340px; top: 79px; position: absolute; width: 116px; height: 19px;" Text="Hospital Address :"></asp:Label>
                                        <asp:Label ID="HNLabel" runat="server" Font-Underline="False" Style="z-index: 1;
                                            left: 340px; top: 43px; position: absolute; width: 101px; height: 19px;" Text="Hospital Name :"></asp:Label>
                                        <asp:Label ID="NotUsedLabel" runat="server" Font-Bold="True" Font-Underline="False"
                                            Style="z-index: 1; left: 340px; top: 172px; position: absolute; width: 98px"
                                            Text="Not Used :"></asp:Label>
                                        <asp:Label ID="HALabel" runat="server" Font-Underline="False" Style="z-index: 1;
                                            left: 340px; top: 14px; position: absolute; width: 134px" Text="Hospital Attended :"></asp:Label>
                                        <asp:Label ID="TCLabel" runat="server" Font-Underline="False" Style="z-index: 1;
                                            left: 10px; top: 83px; position: absolute; width: 134px" Text="Trauma Counseling :"></asp:Label>
                                        <asp:Label ID="NODTLabel" runat="server" Style="z-index: 1; left: 10px; top: 44px;
                                            position: absolute; width: 265px" Text="Number Of Days Restricted/Job Transfer :"></asp:Label>
                                        <asp:Label ID="NODAFWLabel" runat="server" Font-Underline="False" Style="z-index: 1;
                                            left: 10px; top: 10px; position: absolute; width: 247px; height: 19px; right: 396px;"
                                            Text="Number Of Days Away From Work :"></asp:Label>
                                        <asp:DropDownList TabIndex="6" ID="HospitalAttended" runat="server" Style="z-index: 1;
                                            left: 475px; top: 12px; position: absolute; width: 70px;">
                                            <asp:ListItem Selected="True">No</asp:ListItem>
                                            <asp:ListItem>Yes</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:DropDownList TabIndex="3" ID="Counseling" runat="server" Style="z-index: 1;
                                            left: 158px; top: 84px; position: absolute; width: 51px;">
                                            <asp:ListItem Selected="True">No</asp:ListItem>
                                            <asp:ListItem>Yes</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:TextBox ID="NODRJT" TabIndex="2" runat="server" Style="z-index: 1; left: 279px;
                                            top: 42px; position: absolute; width: 44px;"></asp:TextBox>
                                        <asp:TextBox ID="MedicAddress" TabIndex="5" runat="server" Style="z-index: 1; left: 156px;
                                            top: 186px; position: absolute; width: 161px; height: 52px;" TextMode="MultiLine"></asp:TextBox>
                                        <asp:TextBox ID="MedicComment" TabIndex="4" runat="server" Style="z-index: 1; left: 156px;
                                            top: 123px; position: absolute; width: 161px; height: 52px;" TextMode="MultiLine"></asp:TextBox>
                                        <asp:TextBox ID="HospitalAddress" TabIndex="8" runat="server" Style="z-index: 1;
                                            left: 475px; top: 84px; position: absolute; width: 110px; height: 52px;" TextMode="MultiLine"></asp:TextBox>
                                        <asp:TextBox ID="HospitalName" TabIndex="7" runat="server" Style="z-index: 1; left: 475px;
                                            top: 45px; position: absolute; width: 115px;"></asp:TextBox>
                                        <asp:TextBox ID="NODAFW" TabIndex="1" runat="server" Style="z-index: 1; left: 279px;
                                            top: 10px; position: absolute; width: 44px;"></asp:TextBox>
                                        <asp:ListBox ID="NotUsed" TabIndex="9" runat="server" Style="z-index: 1; left: 475px;
                                            top: 160px; position: absolute; height: 63px; width: 115px;"></asp:ListBox>
                                    </asp:Panel>
                                    <asp:Panel ID="Panel12" runat="server" BackColor="#EFF3B6" BorderColor="Silver" BorderStyle="Solid"
                                        BorderWidth="1" Style="z-index: 1; left: 19px; top: 290px; position: absolute;
                                        width: 636px" HorizontalAlign="Center" Height="100">
                                        <asp:UpdatePanel ID="tablepanel" runat="server">
                                            <ContentTemplate>
                                                <span id="allspans">
                                                    <asp:Table ID="addT" runat="server" GridLines="Both" HorizontalAlign="Center" Style="z-index: 1;
                                                        position: absolute; width: 115px; top: 6px; left: 29px;">
                                                        <asp:TableRow ID="TableRow1" runat="server">
                                                            <asp:TableCell ID="TableCell1" runat="server"></asp:TableCell>
                                                            <asp:TableCell ID="TableCell2" runat="server">Body Part Affected</asp:TableCell>
                                                            <asp:TableCell ID="TableCell3" runat="server">Nature Of Injury</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow ID="addR" runat="server">
                                                            <asp:TableCell ID="c1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</asp:TableCell>
                                                            <asp:TableCell ID="c2" runat="server">
                                                                <asp:DropDownList TabIndex="10" ID="strBodyPart_" Width="220" runat="server">
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
                                                            <asp:TableCell ID="c3" runat="server">
                                                                <asp:DropDownList TabIndex="11" ID="strNatureOfInjury_" Width="300" runat="server">
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
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow  runat="server" HorizontalAlign="Left">
                                                            <asp:TableCell ColumnSpan="3" runat="server">
                                                                <input tabindex="12" onclick="addRow1();" type="button" value="Add" />&nbsp;&nbsp;Multiple Injury/Illness
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </span>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:CheckBox TabIndex="13" ID="AddAnotherInjury" runat="server" Style="z-index: 1;
                                            left: 473px; top: 100px; position: absolute; width: 158px;" Text="Add Another Injury" />
                                        <asp:ImageButton ID="NextButton2" runat="server" ImageUrl="~/Images/Buttons/FrwdArrow2.jpg"
                                            Style="z-index: 0; left: 500px; top: 117px; position: absolute; height: 44px;
                                            width: 48px" OnClick="NextButton2_Click" ToolTip="Next" />
                                        <asp:ImageButton ID="PreviousButton2" runat="server" ImageUrl="~/Images/Buttons/BackButton2.jpg"
                                            Style="z-index: 0; left: 80px; top: 117px; position: absolute; height: 44px;
                                            width: 48px" OnClick="PreviousButton2_Click" ToolTip="Previous" />
                                        <asp:ImageButton ID="HelpButton2" runat="server" ImageUrl="~/Images/Buttons/HelpButton3.jpg"
                                            Style="z-index: 0; left: 230px; top: 117px; position: absolute; height: 44px;
                                            width: 48px" ToolTip="Help !!" />
                                        <asp:ImageButton ID="CancelButton2" runat="server" ImageUrl="~/Images/Buttons/CancelButton4.jpg"
                                            Style="z-index: 0; left: 380px; top: 117px; position: absolute; height: 44px;
                                            width: 48px" OnClick="CancelButton_Click" ToolTip="Cancel" />
                                    </asp:Panel>
                                </asp:Panel>
                            </asp:View>
                        </asp:MultiView>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </asp:Panel>
    </div>
</asp:Content>
