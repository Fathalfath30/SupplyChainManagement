<?php
/*
 //
 //    ______    _   _           _  __      _   _     ____   ___
 //   |  ____|  | | | |         | |/ _|    | | | |   |___ \ / _ \
 //   | |__ __ _| |_| |__   __ _| | |_ __ _| |_| |__   __) | | | |
 //   |  __/ _` | __| '_ \ / _` | |  _/ _` | __| '_ \ |__ <| | | |
 //   | | | (_| | |_| | | | (_| | | || (_| | |_| | | |___) | |_| |
 //   |_|  \__,_|\__|_| |_|\__,_|_|_| \__,_|\__|_| |_|____/ \___/
 //
 // Licensed under GNU General Public License v3.0
 // http://www.gnu.org/licenses/gpl-3.0.txt
 // Written by Fathalfath30. Email : fathalfath30@gmail.com
 // Follow me on GithHub : https://github.com/Fathalfath30
 //
*/

include 'init.php';
define('DEMO_TYPE', 'MANUFAKTUR');

if (isset($_POST['pst-username']) != null) {
    if ($_POST['pst-username'] == "indokedelai") {
        header("Location: supplier.php");
        exit();
    }

    header(sprintf('Location: %s.php', $_POST['pst-username']));

}

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title>SCM Prototype S1 - Login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <?php
    include 'include/head.php';
    ?>
</head>
<body class="external-page sb-l-c sb-r-c">
<div id="main" class="animated fadeIn">
    <section id="content_wrapper">
        <div id="canvas-wrapper">
            <canvas id="demo-canvas"></canvas>
        </div>
        <section id="content">
            <div class="admin-form theme-info" id="login2">

                <div class="row mb10 table-layout">
                    <div class="col-xs-6 va-m pln"></div>
                    <div class="col-xs-6 text-right va-b pr5">
                        <div class="login-links">
                            <a href="pages_login.html" class="active" title="Sign In">Login</a>
                            <span class="text-white"> | </span>
                            <a href="pages_register.html" class="" title="Register">Lupa password</a>
                        </div>

                    </div>

                </div>

                <div class="panel panel-info mt10 br-n">

                    <div class="heading-border bg-white"></div>
                    <form method="post" action="" id="contact">
                        <div class="panel-body bg-light p30">
                            <div class="row">
                                <div class="col-sm-7 pr30">

                                    <div class="section">
                                        <label for="username" class="field-label text-muted fs18 mb10">Email</label>
                                        <label for="username" class="field prepend-icon">
                                            <input type="text" name="pst-username" id="pst-username" class="gui-input"
                                                   placeholder="Masukan Email" autocomplete="off" autofocus="true">
                                            <label for="pst-username" class="field-icon"><i class="fa fa-user"></i>
                                            </label>
                                        </label>
                                    </div>
                                    <!-- end section -->

                                    <div class="section">
                                        <label for="username" class="field-label text-muted fs18 mb10">Password</label>
                                        <label for="password" class="field prepend-icon">
                                            <input type="password" name="pst-password" id="pst-password"
                                                   class="gui-input"
                                                   placeholder="Masukan Password">
                                            <label for="pst-password" class="field-icon"><i class="fa fa-lock"></i>
                                            </label>
                                        </label>
                                    </div>
                                    <!-- end section -->

                                </div>
                                <div class="col-sm-5 br-l br-grey pl30">
                                    <h3 class="mb25"> Supply Chain Management</h3>

                                    <p class="mb15">
                                        Selamat datang di aplikasi Supply Chain Management (Kecap Bango). Silahkan login untuk mengakses
                                        halaman dashboard anda. Pastikan anda logout setelah menggunakan aplikasi ini untuk menghindari
                                        hal - hal yang tidak di inginkan
                                    </p>
                                </div>
                            </div>
                        </div>
                        <!-- end .form-body section -->
                        <div class="panel-footer clearfix p10 ph15">
                            <button type="submit" class="button btn-primary mr10 pull-right">Login</button>
                        </div>
                        <!-- end .form-footer section -->
                    </form>
                </div>
                <p style="color:#FFF; text-align:center; font-weight: 500;">Copyright &copy;
                                                                            2017 -
                    <a style="color: #0077b3"
                       href="#">PT Kecap Bango</a> All Right Reserved.
                    <br>Powered by <a href="#"
                                      style="color: #0077b3" target="_blank">S1</a>.
                </p>
                </p>

            </div>
        </section>
    </section>
</div>
</body>
</html>