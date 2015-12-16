<%@ Page EnableViewState="false" Language="C#" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="f100_thay_doi_nguyen_vong.aspx.cs" Inherits="WEB.f100_thay_doi_nguyen_vong" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thay đổi nguyện vọng</title>
    <link href="Style/normalize.css" rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" href="Style/finder.css" type="text/css"/>
    <link rel="stylesheet" href="Style/template.css" type="text/css"/>
    <link rel="stylesheet" href="Style/styles.css" type="text/css"/>
    <link rel="stylesheet" href="Style/responsiveslides.css" type="text/css"/>
    <meta charset='utf-8'/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="Style/styles1.css"/>   
    <meta http-equiv="content-type" content="text/html;charset=utf-8" />
    <!-- Insert to your webpage before the </head> -->
   <%-- <link rel="stylesheet" type="text/css" href="sliderengine/amazingslider-0.css"/>--%>
    <script>
        function newDoc() {
            window.location.assign("http://dtdh.hust.edu.vn/gioi-thieu")
        }
        function newDoc1() {
            window.location.assign("http://dtdh.hust.edu.vn/tin-tuc")
        }
        function newDoc2() {
            window.location.assign("http://dtdh.hust.edu.vn/tuyen-sinh")
        }
        function newDoc3() {
            window.location.assign("http://dtdh.hust.edu.vn/dao-tao2")
        }
        function newDoc4() {
            window.location.assign("http://dtdh.hust.edu.vn/tuyen-sinh")
        }
        function newDoc5() {
            window.location.assign("http://google.com")
        }
       
    </script>
    <%-- <script src="sliderengine/jquery.js"></script>
    <script src="sliderengine/amazingslider.js"></script>--%>
   
   <%-- <script src="sliderengine/initslider-0.js"></script>--%>
     <%--<script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>--%>
    
    <style type="text/css">
        .auto-style2 {
            width: 211px;
        }

        table {
            border-collapse: collapse;
            background-color: aliceblue;
        }

        table, td, th {
            border: 1px solid black;
        }
        .auto-style4 {
            width: 211px;
            height: 41px;
        }
    </style>
</head>
<body style="background-color:#0015ff">
    <form id="form1" runat="server" style="background-color:#0015ff">
        <div class="" style="background-color:#0015ff">
        
         <div class="" style="float:left;width:auto;height:100%;margin-left:30px;margin-right:30px; background-color:#EBEBEB">
              <div style="background-image: url('Images/back_ground_back_khoa.png'); height: 159px; background-size: cover;">
                    <div style="float:right">
                      [<a href ="Login.aspx" style ="text-decoration:underline;color:blue">Thoát đăng nhập</a>]
                  </div>
                  <div style="float:right">
                      
                       [<a href ="f200_doi_mat_khau.aspx" style ="text-decoration:underline;color:blue">Đổi mật khẩu</a>]
                  </div>
              
            <div style="float: right; color:white;margin-right:10px">
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Xin chào bạn "></dx:ASPxLabel>
                <dx:ASPxLabel ID="m_lbl_ho_ten_ts" runat="server" Text="Mạc Hồng Young"></dx:ASPxLabel>
            </div>
                  
        </div>
        <div id='cssmenu'>
            <ul>
                <li class='active'><a href='#'><span>Trang chủ</span></a></li>
                <li><a href='#' onclick="newDoc()" ><span>Giới thiệu</span></a></li>
                <li><a href='#' onclick="newDoc1()"><span>Tin tức</span></a></li>
                <li class='last' onclick="newDoc2()"><a href='#'><span>Tuyển sinh</span></a></li>
                <li class='last' onclick="newDoc3()"><a href='#'><span>Đào tạo</span></a></li>
                <li class='last' onclick="newDoc4()"><a href='#'><span>CT đặc biệt</span></a></li>
                <li class='last' onclick="newDoc5()"><a href='#'><span>Trợ giúp</span></a></li>

            </ul>
        </div>
             <!-- slide amazing-->
      <%--  <div>
            <div id="amazingslider-wrapper-0" style="display: block; position: relative; max-width: 900px; margin: 90px auto 48px;">
                <div id="amazingslider-0" style="display: block; position: relative; margin: 0 auto;">
                    <ul class="amazingslider-slides" style="display: none;">
                        <li>
                            <img src="images/bachkhoahanoi1.png" alt="bachkhoahanoi1" />
                        </li>
                        <li>
                            <img src="images/c1bachkhoa.jpg" alt="c1bachkhoa" />
                        </li>
                        <li>
                            <img src="images/hust2.png" alt="hust2" />
                        </li>
                        <li>
                            <img src="images/hust3.png" alt="hust3" />
                        </li>
                        <li>
                            <img src="images/hust4.png" alt="hust4" />
                        </li>
                        <li>
                            <img src="images/IMG_4670.JPG" alt="IMG_4670" />
                        </li>
                        <li>
                            <img src="images/svbk.JPG" alt="svbk" />
                        </li>
                        <li>
                            <img src="images/thuvienbk.png" alt="thuvienbk" />
                        </li>
                    </ul>
                    <ul class="amazingslider-thumbnails" style="display: none;">
                        <li>
                            <img src="images/bachkhoahanoi1-tn.png" alt="DHBKHN" /></li>
                        <li>
                            <img src="images/c1bachkhoa-tn.jpg" alt="DHBKHN" /></li>
                        <li>
                            <img src="images/hust2-tn.png" alt="DHBKHN" /></li>
                        <li>
                            <img src="images/hust3-tn.png" alt="DHBKHN" /></li>
                        <li>
                            <img src="images/hust4-tn.png" alt="DHBKHN" /></li>
                        <li>
                            <img src="images/IMG_4670-tn.JPG" alt="DHBKHN" /></li>
                        <li>
                            <img src="images/svbk-tn.JPG" alt="DHBKHN" /></li>
                        <li>
                            <img src="images/thuvienbk-tn.png" alt="ThuVien" /></li>
                    </ul>
                    <div class="amazingslider-engine"><a href="http://amazingslider.com" title="Responsive JavaScript Slideshow"></a></div>
                </div>
            </div>

        </div>--%>

              <!-- --------------->
        <div style="margin-left: 30px;background-color:#E5EECF;border-radius:4px;width:20%" >
            <div style="text-align:center;color:red;border-top-left-radius:4px;border-top-right-radius:4px;background-color:#D3E4A6">Thông tin sinh viên</div>
            <div style="background-color:#0015ff;height:5px;color:#0015ff">.</div>
            <div style="background-color:#E5EECF;margin-left:50px;border-bottom-left-radius:4px;border-bottom-right-radius:4px;">
            <p>
                ♦ Số báo danh:
                <asp:Label ID="m_lbl_so_bao_danh" runat="server" Text="" Font-Bold="true"></asp:Label>
            </p>
            <p>
                ♦ Họ tên:
                <asp:Label ID="m_lbl_ho_ten" runat="server" Text="" Font-Bold="true"></asp:Label>
            </p>
            <p>
                ♦ Ngày sinh:
                <asp:Label ID="m_lbl_ngay_sinh" runat="server" Text="" Font-Bold="true"></asp:Label>
            </p>
            <p>
                ♦ Khu vực:
                <asp:Label ID="m_lbl_khu_vuc" runat="server" Text="" Font-Bold="true"></asp:Label>
            </p>
            <p>
                ♦ Đối tượng:
                <asp:Label ID="m_lbl_doi_tuong" runat="server" Text="" Font-Bold="true"></asp:Label>
            </p>
            <p>
                ♦ Ưu tiên:
                <asp:Label ID="m_lbl_uu_tien" runat="server" Text="" Font-Bold="true"></asp:Label>
            </p>
                </div>
        </div>
        <!-- danh sách điểm thi của thí sinh-->
        <div style="float: none; margin-right: 30px">
            <div style="margin-bottom:2px;border-radius:4px;margin-left:30px;margin-right:30px;margin-top:10px">
            <h1 style="margin-left:30px"><i style="color: black">Danh sách điểm thi của thí sinh:</i></h1>
                </div>
            <div style="">
            <table class="table_van" style="margin-left: 30px; margin-right: 30px; text-align: center;border:solid;border-color:#0015ff">
                <tr>
                    <td class="auto-style4">Toán</td>
                    <td class="auto-style4">Văn</td>
                    <td class="auto-style4">Lý</td>
                    <td class="auto-style4">Hóa</td>                    
                    <td class="auto-style4">Sinh</td>
                    <td class="auto-style4">Sử</td>
                    <td class="auto-style4">Địa</td>
                    <td class="auto-style4">Tiếng Anh</td>
                    <td class="auto-style4">Tiếng Nga</td>
                    <td class="auto-style4">Tiếng Pháp</td>
                    <td class="auto-style4">Tiếng Trung</td>
                    <td class="auto-style4">Tiếng Đức</td>
                    <td class="auto-style4">Tiếng Nhật</td>

                </tr>
                <tr>
                    <td class="auto-style2">
                       
                        <dx:ASPxLabel ID="m_lbl_toan" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       
                    </td>
                    <td class="auto-style2">
                        
                        <dx:ASPxLabel ID="m_lbl_van" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                        
                    </td>
                    <td class="auto-style2">
                       
                        <dx:ASPxLabel ID="m_lbl_ly" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       
                    </td>
                    <td class="auto-style2">
                       

                        <dx:ASPxLabel ID="m_lbl_hoa" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       

                    </td>
                    <td class="auto-style2">
                       

                        <dx:ASPxLabel ID="m_lbl_sinh" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       

                    </td>
                    <td class="auto-style2">
                       

                        <dx:ASPxLabel ID="m_lbl_su" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       

                    </td>
                    <td class="auto-style2">
                        

                        <dx:ASPxLabel ID="m_lbl_dia" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                        

                    </td>
                    <td class="auto-style2">
                       

                        <dx:ASPxLabel ID="m_lbl_Anh" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       

                    </td>
                    <td class="auto-style2">
                      

                        <dx:ASPxLabel ID="m_lbl_Tieng_Nga" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                      

                    </td>
                    <td class="auto-style2">
                        

                        <dx:ASPxLabel ID="m_lbl_Tieng_Phap" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                        

                    </td>
                    <td class="auto-style2">
                       

                        <dx:ASPxLabel ID="m_lbl_Tieng_Trung" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       

                    </td>
                    <td class="auto-style2">
                     

                        <dx:ASPxLabel ID="m_lbl_Tieng_Duc" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                     

                    </td>
                    <td class="auto-style2">
                       

                        <dx:ASPxLabel ID="m_lbl_Tieng_Nhat" runat="server" Text="Không có">
                        </dx:ASPxLabel>
                       

                    </td>
                </tr>
            </table>
                </div>
        </div>


       

        <!-- danh sách nguyện vọng của thí sinh-->
        <div style="margin-right: 30px;margin-top:10px">
            <div style="margin-bottom:2px;border-radius:4px;margin-left: 30px">
            <h1><i style="color: black; margin-left: 30px">Danh sách nguyện vọng của thí sinh:</i></h1>
            </div>
            <div >
            <table style="text-align: center; margin-bottom:30px; margin-left: 30px;border:solid;border-color:#0015ff; margin-right: 30px;" class="table_van">
                <tr style="text-align: center;border-top:solid;border-left:solid;border-right:solid;border-color:#0015ff">
                    <td class="auto-style2" colspan="2">
                        <dx:ASPxCheckBox ID="m_ck_nv1" Text="Nguyện vọng 1:" runat="server" Checked="True" CheckState="Checked" Enabled="False" Theme="Youthful" AutoPostBack="true">
                        </dx:ASPxCheckBox>
                       </td>
                    <td class="auto-style2" colspan="2">
                        <dx:ASPxCheckBox ID="m_ck_nv2" runat="server" OnCheckedChanged="m_ck_nv2_CheckedChanged" Theme="Youthful" Text="Nguyện vọng 2:" AutoPostBack="true">
                        </dx:ASPxCheckBox>
                       </td>
                    <td class="auto-style2" colspan="2"> 
                        <dx:ASPxCheckBox ID="m_ck_nv3" runat="server" Theme="Youthful" OnCheckedChanged="m_ck_nv3_CheckedChanged" Text="Nguyện vọng 3:" AutoPostBack="true">
                        </dx:ASPxCheckBox>
                       </td>
                    <td class="auto-style2" colspan="2">
                        <dx:ASPxCheckBox ID="m_ck_nv4" runat="server" Theme="Youthful" OnCheckedChanged="m_ck_nv4_CheckedChanged" Text="Nguyện vọng 4:" AutoPostBack="true">
                        </dx:ASPxCheckBox>
                       </td>
                </tr>
                <tr style="border-left:solid;border-right:solid;border-color:#0015ff">
                    <td class="auto-style2">Nhóm ngành:</td>
                    <td class="auto-style2">
                       
                        <dx:ASPxComboBox ID="m_cbo_nhom_nganh_NV1" runat="server" Theme="Youthful" ValueType="System.String" OnSelectedIndexChanged="m_cbo_nhom_nganh_NV1_SelectedIndexChanged" AutoPostBack="true">
                        </dx:ASPxComboBox>
                       
                    </td>
                    <td class="auto-style2">Nhóm ngành:</td>
                    <td class="auto-style2">
                        
                        <dx:ASPxComboBox ID="m_cbo_nhom_nganh_NV2" runat="server" Theme="Youthful" ValueType="System.String" OnSelectedIndexChanged="m_cbo_nhom_nganh_NV2_SelectedIndexChanged" AutoPostBack="true">
                        </dx:ASPxComboBox>
                        
                    </td>
                    <td class="auto-style2">Nhóm ngành:</td>
                    <td class="auto-style2">
                      
                        <dx:ASPxComboBox ID="m_cbo_nhom_nganh_NV3" runat="server" Theme="Youthful" ValueType="System.String" OnSelectedIndexChanged="m_cbo_nhom_nganh_NV3_SelectedIndexChanged" AutoPostBack="true">
                        </dx:ASPxComboBox>
                      
                    </td>
                    <td class="auto-style2">Nhóm ngành:</td>
                    <td class="auto-style2">
                       
                        <dx:ASPxComboBox ID="m_cbo_nhom_nganh_NV4" runat="server" Theme="Youthful" ValueType="System.String" OnSelectedIndexChanged="m_cbo_nhom_nganh_NV4_SelectedIndexChanged" AutoPostBack="true">
                        </dx:ASPxComboBox>
                       
                    </td>
                </tr>
                <tr style="border-left:solid;border-right:solid;border-color:#0015ff">
                    <td class="auto-style2">Tổ hợp môn:</td>
                    <td class="auto-style2">
                       
                        <dx:ASPxComboBox ID="m_cbo_to_hop_mon_NV1" runat="server" Theme="Youthful" ValueType="System.String">
                        </dx:ASPxComboBox>
                       
                    </td>
                    <td class="auto-style2">Tổ hợp môn:</td>
                    <td class="auto-style2">
                       
                        <dx:ASPxComboBox ID="m_cbo_to_hop_mon_NV2" runat="server" Theme="Youthful" ValueType="System.String">
                        </dx:ASPxComboBox>
                       
                    </td>
                    <td class="auto-style2">Tổ hợp môn:</td>
                    <td class="auto-style2">
                       
                        <dx:ASPxComboBox ID="m_cbo_to_hop_mon_NV3" runat="server" Theme="Youthful" ValueType="System.String">
                        </dx:ASPxComboBox>
                       
                    </td>
                    <td class="auto-style2">Tổ hợp môn:</td>
                    <td class="auto-style2">
                       
                        <dx:ASPxComboBox ID="m_cbo_to_hop_mon_NV4" runat="server" Theme="Youthful" ValueType="System.String">
                        </dx:ASPxComboBox>
                       
                    </td>
                </tr>
             </table>  
               </div>
           
        </div>

             <div style="margin-left:49%; margin-bottom:5px;">
                        <dx:ASPxButton ID="m_cmd_luu_thay_doi" runat="server" Text="Lưu thay đổi" OnClick="m_cmd_luu_thay_doi_Click" CheckedStyle-CssClass="search_button" BackColor="#00cc00">
                        </dx:ASPxButton>                           
           </div>
         </div>
          <!-- --------------------------------->
        
     </div>
        


        <!-- Thông tin liên lạc với nhà trường-->
       <%-- <div id="bottomwide" style="background-color: #FF3300; margin-top: 30px; margin-left: 0px; margin-right: 0px;float:left">
            <div id="bottom" class="clearfix">
                <div class="user1">
                    <div class="moduletable">


                        <div class="custom">
                            <p><strong>Phòng Đào tạo Đại học</strong></p>
                            <p>Đ/c: Tầng 2-C1, ĐHBK Hà Nội</p>
                        </div>
                    </div>
                </div>
                <div class="user2">
                    <div class="moduletable">


                        <div class="custom">
                            <p>Email:&nbsp;<strong>dtdh@hust.edu.vn</strong></p>
                            <p>Website:&nbsp;<strong>http://dtdh.hust.edu.vn/</strong></p>
                        </div>
                    </div>
                </div>
                <div class="user3">
                    <div class="moduletable">


                        <div class="custom">
                            <p>C1-201: Xử lý học tập |<strong>&nbsp;</strong><strong>04.3868.2305</strong></p>
                            <p>C1-202: TS, đào tạo |&nbsp;<strong>04.3869.2008</strong></p>
                            <p>Fax: 043.8683618</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="tgwide">
                <div id="tg">
                    <div class="footer-left">
                        Trang thông tin Đào tạo Đại học - Trường Đại học Bách Khoa Hà Nội				
                    </div>
                </div>
            </div>

        </div>--%>
        <!--/.relative -->
        <!--/.fluid-container -->
    </form>
</body>
   
</html>
