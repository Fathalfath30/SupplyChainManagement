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
        <li>
            <a class="accordion-toggle <?php echo ($info == "gudang" || $info == "detail") ? "menu-open" : ""; ?>" href="#">
                <span class="glyphicons glyphicons-cargo"></span>
                <span class="sidebar-title">Menu Gudang</span>
                <span class="caret"></span>
            </a>
            <ul class="nav sub-nav">
                <li class="<?php echo (($task == "gudang" || $task == "detail") && ($obj == "bahan-baku" || $obj ==  "bahanb")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=gudang&obj=bahan-baku") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Bahan Baku</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "gudang" || $task == "detail") && ($obj == "barang-jadi" || $obj ==  "barangj")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=gudang&obj=barang-jadi") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Barang Jadi</span>
                    </a>
                </li>
                <!--<li class="<?php echo (($task == "gudang" || $task == "detail") && ($obj == "mro" || $obj ==  "mro")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=gudang&obj=mro") ?>" style="font-weight: bold">
                        <span class="sidebar-title">MRO</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "gudang" || $task == "detail") && ($obj == "barang-proyek" || $obj ==  "barangp")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=gudang&obj=bahan-proyek") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Barang Proyek</span>
                    </a>
                </li>-->
            </ul>
        </li>
        <li>
            <a class="accordion-toggle <?php echo ($info == "supplier" || $info == "order") ? "menu-open" : ""; ?>" href="#">
                <span class="imoon imoon-office"></span>
                <span class="sidebar-title">Data Supplier</span>
                <span class="caret"></span>
            </a>
            <ul class="nav sub-nav">
                <li class="<?php echo (($task == "supplier" || $task == "order") && ($obj == "kedelai")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=supplier&obj=kedelai") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Kedelai Hitam</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "supplier" || $task == "order") && ($obj == "garam")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=supplier&obj=garam") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Garam</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "supplier" || $task == "order") && ($obj == "plastik")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=supplier&obj=plastik") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Plastik</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "supplier" || $task == "order") && ($obj == "botol" || $obj ==  "botol")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=supplier&obj=botol") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Botol</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "supplier" || $task == "order") && ($obj == "gula-merah" || $obj ==  "gmerah")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=supplier&obj=gula-merah") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Gula Merah</span>
                    </a>
                </li>
            </ul>
        </li>
        <li class="<?php echo ($info == "po") ? "active" : ""; ?>">
            <a href="<?php echo base_url("manufaktur.php?task=po") ?>">
                <span class="fa fa-money"></span>
                <span class="sidebar-title">PO</span>
            </a>
        </li>
        <!--
        <li>
            <a class="accordion-toggle <?php echo ($info == "order") ? "menu-open" : ""; ?>" href="#">
                <span class="imoon imoon-box-add"></span>
                <span class="sidebar-title">Pesan Bahan Baku</span>
                <span class="caret"></span>
            </a>
            <ul class="nav sub-nav">
                <li class="<?php echo (($task == "order") && ($obj == "kedelai")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=order&obj=kedelai") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Kedelai Hitam</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "order") && ($obj == "garam")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=order&obj=garam") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Garam</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "order") && ($obj == "plastik")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=order&obj=plastik") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Plastik</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "order") && ($obj == "botol")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=order&obj=botol") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Botol</span>
                    </a>
                </li>
                <li class="<?php echo (($task == "order") && ($obj == "gula-merah")) ? "active" : ""; ?>">
                    <a href="<?php echo base_url("manufaktur.php?task=order&obj=gula-merah") ?>" style="font-weight: bold">
                        <span class="sidebar-title">Gula Merah</span>
                    </a>
                </li>
            </ul>
        </li>
        -->
        <?php
        break;
}
?>