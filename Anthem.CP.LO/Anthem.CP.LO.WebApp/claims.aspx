<%@ Page Title="Claim Status" Language="C#" MasterPageFile="~/CPLO.Master" AutoEventWireup="true" CodeBehind="claims.aspx.cs" Inherits="Anthem.CP.LO.WebApp.claims" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="col-md-8">
        <form class="form-horizontal" runat="server">

            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Claim Status</h3>
                </div>

                <div class="panel-body">
                     <div id="panelErrorMessages" class="alert alert-danger " role="alert">
                         <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                         <span class="sr-only">Error:</span>
                        Please enter the Valid Details
                    </div>
                    <div class="form-group">

                        <label for="lblClaimNumber" class="control-label col-xs-3">Claim Number</label>
                        <div class="col-xs-8">
                            <input id="txtClaimNumber" type="text" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-4 col-xs-12">
                            <asp:Button ID="btnSubmit" runat="server" type="submit" class="btn btn-primary" Text="Search"></asp:Button>
                        </div>
                </div>

            </div>
            </div> 


            <div class="panel panel-primary cols-xs-4">
                <div class="panel-body cols-xs-4">
                    <div class="form-group">
                        <label for="lblClaimNumber" class="control-label col-xs-2">Claim Number</label>

                        <asp:Label ID="lblClaimNumber" runat="server" ></asp:Label>
                    </div>

                </div>
                <div class="form-group">
                    <label for="lblClaimType" class="control-label col-xs-2">Claim Type</label>
                     <asp:Label ID="lblClaimType" runat="server" ></asp:Label>
                   
                </div>


                <div class="form-group">
                    <label for="lblstatus" class="control-label col-xs-2">Status</label>
                     <asp:Label ID="lblstatus" runat="server"  ></asp:Label>
                    
                </div>
            </div>
        </form>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#ClaimsNav").addClass("active");
        
            $("#panelErrorMessages").hide();
        });
       
            $("#<%= btnSubmit.ClientID%>").click(function (e) {
                //var email = $('#txtEmail').val();
                var isValid = true;
                $('input').each(function () {
                    if ($.trim($(this).val()) == '') {
                        isValid = false;
                        $("#panelErrorMessages").show();
                        $(this).css({

                            "border": "1px solid red",

                            "background": "#FFCECE"

                        });

                        if (isValid == false) {
                            e.preventDefault();
                        }
                    }

                });
            });
    </script>
   
</asp:Content>
