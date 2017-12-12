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

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title><?php echo sprintf("SCM Prototype S1 - %s", str_replace(".", "", ucfirst($task))) ?></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <?php
    include 'include/head.php';
    ?>
</head>
<body class="<?php echo $class ?>">
<div id="main">
    <header class="navbar bg-light navbar-fixed-top">
        <?php include 'include/navbar.php' ?>
    </header>

    <aside id="sidebar_left" class="sidebar-light light nano nano-primary affix">
        <div class="nano-content">
            <ul class="nav sidebar-menu">
                <?php include 'include/sidebar-supplier.php' ?>
            </ul>
        </div>
    </aside>

    <section id="content_wrapper">
        <header id="topbar">
            <div class="topbar-left">
                <ol class="breadcrumb">
                    <li class="crumb-link">
                        <a href="<?php echo base_url('manufaktur.php') ?>"><b>Manufaktur</b></a>
                    </li>
                    <li>Dashboard</li>
                </ol>
            </div>
        </header>
        <div id="content" class="<?php echo ($task == '404') ? 'pn' :''; ?> animated fadeIn">
            <?php include 'content/content-supplier.php' ?>
            <div class="row col-lg-12">
                <p style="color:rgba(192, 192, 192, 1); text-align:center; font-weight: 500;">Copyright &copy;
                                                                                              2017 -
                    <a style="color: rgba(0, 119, 179, 0.4)"
                       href="#">PT Kecap Bango</a> All Right Reserved.
                    <br>Powered by <a href="#"
                                      style="color: rgba(0, 119, 179, 0.4)" target="_blank">S1</a>.
                </p>
            </div>
        </div>
    </section>
</div><?php
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

getJavascript(array (
    "assets/vendor/jquery/jquery-1.11.1.min.js",
    "assets/vendor/jquery/jquery_ui/jquery-ui.min.js",
    "assets/js/bootstrap/bootstrap.min.js",
    "assets/js/jquery.sparkline.min.js",
    "assets/js/bootstrap/holder.min.js",
    "assets/js/utility/utility.js",
    "assets/js/main.js",
    "assets/vendor/plugins/magnific/jquery.magnific-popup.js",
    "assets/admin-tools/admin-forms/js/jquery.validate.min.js",
    "assets/vendor/plugins/datatables/media/js/jquery.dataTables.js",
    "assets/vendor/plugins/datatables/extensions/TableTools/js/dataTables.tableTools.min.js",
    "assets/vendor/plugins/datatables/media/js/dataTables.bootstrap.js",
));
?>
<script type='text/javascript'>
    $ (document).ready (function () {
        $ ('#dataTables').dataTable ({
            "aoColumns": [
                null,
                null,
                null,
                null,
                null,
                {"bSortable": false}
            ],
            "order": [
                [3, "asc"],
                [4, "asc"]
            ],
            "oLanguage": {
                "oPaginate": {
                    "sPrevious": "",
                    "sNext": ""
                }
            },
            "iDisplayLength": 10,
            "aLengthMenu": [
                [10, 25, 50, -1],
                [10, 25, 50, "All"]
            ],
            "sDom": '<"dt-panelmenu clearfix"lfr>t<"dt-panelfooter clearfix"ip>',
            "oTableTools": {
                "sSwfPath": "vendor/plugins/datatables/extensions/TableTools/swf/copy_csv_xls_pdf.swf"
            }
        });
    });
</script>
</body>
</html>
