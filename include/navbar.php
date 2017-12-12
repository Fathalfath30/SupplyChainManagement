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
?>
<div class="navbar-branding">
    <a class="navbar-brand" href="dashboard.html">
        <img src="<?php echo base_url("assets/img/logo-unilever.png") ?>" width="90%" />
        <b>PT.Kecap Bango</b>
    </a>
    <span id="toggle_sidemenu_l" class="glyphicons glyphicons-show_lines"></span>
    <ul class="nav navbar-nav pull-right hidden">
        <li>
            <a href="#" class="sidebar-menu-toggle">
                <span class="octicon octicon-ruby fs20 mr10 pull-right "></span>
            </a>
        </li>
    </ul>
</div>
<ul class="nav navbar-nav navbar-right">
    <li>
        <a href="<?php echo base_url('login.php') ?>">
            <span class="fa fa-power-off"></span>
            <span class="fw600"><b>Logout</b></span>
        </a>
    </li>
</ul>
