<%@ Page Title="User Registration" Language="C#" MasterPageFile="~/CPLO.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Anthem.CP.LO.WebApp.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="col-md-8">

        <form class="form-horizontal" runat="server">
            
                
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Registration</h3>
                </div>
             
                <div class="panel-body panel-sm">
                    <div id="panelErrorMessages" class="alert alert-danger" role="alert">
                        <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                         <span class="sr-only">Error:</span>
                        Please enter valid Details.
                    </div>
                    

                    <div class="form-group">


                        <label for="lblEmailAddress" class="control-label col-xs-3 " >Email Address *</label>

                        <div class="col-xs-8">
                          <input type="email" id="txtEmail" class="form-control" />

                        </div>
                    </div>
                    <div class="form-group">
                        <label for="lblPassword" class="control-label col-xs-3">Password *</label>
                        <div class="col-xs-8">
                           <input type="password" id="txtPassword" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="lblFirstName" class="control-label col-xs-3">First Name *</label>
                        <div class="col-xs-8">
                            <input type="text" id="txtFirstName" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="lblLastName" class="control-label col-xs-3">Last Name *</label>
                        <div class="col-xs-8">
                            <input type="text" id="txtLastName" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="lblAddress" class="control-label col-xs-3">Address *</label>
                        <div class="col-xs-8">
                            <input id="Text1" class="form-control" type="text" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="lblPhoneNumber" class="control-label col-xs-3">Phone No* </label>
                        <div class="col-xs-8">
                            <input type="number" id="txtPhoneNumber" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-4 col-xs-12">
                            <asp:Button runat="server" ID="btnSubmit" Cssclass="btn btn-primary" Text="Submit"></asp:Button>
                        </div>
                    </div>
                    
                </div>
                    
            </div>
                
          
            
          
        </form>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#RegistrationNav").addClass("active");
            $("#panelErrorMessages").hide();
           
        });
        
        $("#<%= btnSubmit.ClientID%>").click(function (e) {

            var isValid = true;

            $('input').each(function () {

                if ($.trim($(this).val()) == '') {

                    isValid = false;

                    $("#panelErrorMessages").show();
                    $(this).css({

                        "border": "1px solid red",

                        "background": "#FFCECE"

                    });

                }



            });

            if (isValid == false)

                e.preventDefault();


            
        });
       





       
        

    </script>
</asp:Content>
