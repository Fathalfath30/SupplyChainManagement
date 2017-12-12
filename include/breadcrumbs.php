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
switch ( DEMO_TYPE ) {
    case 'MANUFAKTUR':
        ?>
        <li class="crumb-link">
            <a href="<?php echo base_url('manufaktur.php') ?>"><b>Manufaktur</b></a>
        </li>
        <li class="crumb-trail">
            <?php echo ucfirst($task) ?>
        </li>
        <?php
        if ($obj != "") {
            ?>
            <li class="crumb-trail">
                <?php echo ucfirst(str_replace("-", " ", $obj)) ?>
            </li>
            <?php
        }
        break;
}