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
switch ( $task ) {
    case 'dashboard':
        include 'content/supplier/dashboard/view.php';
        break;
    case 'detail':
        switch ( $obj ) {
            case 'bahanb':
                include 'content/supplier/detail-bahanb/view.php';
                break;
            case 'barangj':
                include 'content/supplier/detail-barangj/view.php';
                break;
            case'kedelai':
                include 'content/supplier/detail-kedelai/view.php';
                break;
            case 'garam':
                include 'content/supplier/detail-garam/view.php';
                break;
            case 'botol':
                include 'content/supplier/detail-botol/view.php';
                break;
            case 'plastik':
                include 'content/supplier/detail-plastik/view.php';
                break;
            case 'gmerah':
                include 'content/supplier/detail-gmerah/view.php';
                break;
        }
        break;
    case 'gudang':
        switch ( $obj ) {
            case 'bahan-baku' :
                include 'content/supplier/gudang-bahanb/view/view.php';
                break;
            case 'barang-jadi' :
                include 'content/supplier/gudang-barangj/view/view.php';
                break;
        }
        break;
    case 'supplier':
        switch ( $obj ) {
            case 'kedelai' :
                include 'content/supplier/supplier-kedelai/view/view.php';
                break;
            case 'garam':
                include 'content/supplier/supplier-garam/view/view.php';
                break;
            case 'plastik':
                include 'content/supplier/supplier-plastik/view/view.php';
                break;
            case 'botol':
                include 'content/supplier/supplier-botol/view/view.php';
                break;
            case 'gula-merah':
                include 'content/supplier/supplier-gmerah/view/view.php';
                break;
        }
        break;
    case 'order':
        switch($obj) {
            case 'kedelai' :
                include 'content/supplier/order-kedelai/view.php';
                break;
            case 'garam':
                include 'content/supplier/order-garam/view.php';
                break;
            case 'plastik':
                include 'content/supplier/order-plastik/view.php';
                break;
            case 'botol':
                include 'content/supplier/order-botol/view.php';
                break;
            case 'gmerah':
                include 'content/supplier/order-gmerah/view.php';
                break;
        }
        break;
    case 'po':
        include 'content/supplier/po/view/view.php';
        break;
    case '404':
    default:
        include 'content/404.php';
        break;
}