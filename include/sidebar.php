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
$info = strtolower($task);
$obj = strtolower($object);
switch ( DEMO_TYPE ) {
    case 'MANUFAKTUR':
        ?>
        <li class="sidebar-label pt20">Menu Utama</li>
        <li class="<?php echo ($info == "dashboard") ? "active" : ""; ?>">
            <a href="<?php echo base_url("manufaktur.php?task=dashboard") ?>">
                <span class="fa fa-dashboard"></span>
                <span class="sidebar-title">Dashboard</span>
            </a>
        </li>
        <li class="<?php echo ($info == "po") ? "active" : ""; ?>">
            <a href="<?php echo base_url("manufaktur.php?task=po-bahan-baku") ?>">
                <span class="imoon imoon-box-add"></span>
                <span class="sidebar-title">Pesan Bahan Baku</span>
            </a>
        </li>
        <li class="<?php echo ($info == "jadwal-kirim") ? "active" : ""; ?>">
            <a href="<?php echo base_url("manufaktur.php?task=jadwal-kirim") ?>">
                <span class="fa fa-clock-o"></span>
                <span class="sidebar-title">Jadwal Pengiriman</span>
            </a>
        </li>
        <li class="<?php echo ($info == "dashboard") ? "active" : ""; ?>">
            <a href="<?php echo base_url("manufaktur.php?task=dashboard") ?>">
                <span class="fa fa-users"></span>
                <span class="sidebar-title">B2B</span>
            </a>
        </li>
        <li class="<?php echo ($info == "dashboard") ? "active" : ""; ?>">
            <a href="<?php echo base_url("manufaktur.php?task=dashboard") ?>">
                <span class="fa fa-dashboard"></span>
                <span class="sidebar-title">Pemesanan Distributor</span>
            </a>
        </li>
        <?php
        break;
}
?>