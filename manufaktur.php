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
                <?php include 'include/sidebar.php' ?>
            </ul>
        </div>
    </aside>

    <section id="content_wrapper">
        <header id="topbar">
            <div class="topbar-left">
                <ol class="breadcrumb">
                    <?php include 'include/breadcrumbs.php'; ?>
                </ol>
            </div>
        </header>
        <div id="content" class="<?php echo ($task == '404') ? 'pn' :''; ?> animated fadeIn">
            <?php include 'content/content.php' ?>
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
</div>
<?php
include 'include/javascript.php'
?>
</body>
</html>
