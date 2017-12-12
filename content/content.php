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
        include 'content/manufaktur/dashboard/view.php';
        break;
    case 'detail':
        switch ( $obj ) {
            case 'bahanb':
                include 'content/manufaktur/detail-bahanb/view.php';
                break;
            case 'barangj':
                include 'content/manufaktur/detail-barangj/view.php';
                break;
            case'kedelai':
                include 'content/manufaktur/detail-kedelai/view.php';
                break;
            case 'garam':
                include 'content/manufaktur/detail-garam/view.php';
                break;
            case 'botol':
                include 'content/manufaktur/detail-botol/view.php';
                break;
            case 'plastik':
                include 'content/manufaktur/detail-plastik/view.php';
                break;
            case 'gmerah':
                include 'content/manufaktur/detail-gmerah/view.php';
                break;
        }
        break;
    case 'gudang':
        switch ( $obj ) {
            case 'bahan-baku' :
                include 'content/manufaktur/gudang-bahanb/view/view.php';
                break;
            case 'barang-jadi' :
                include 'content/manufaktur/gudang-barangj/view/view.php';
                break;
        }
        break;
    case 'supplier':
        switch ( $obj ) {
            case 'kedelai' :
                include 'content/manufaktur/supplier-kedelai/view/view.php';
                break;
            case 'garam':
                include 'content/manufaktur/supplier-garam/view/view.php';
                break;
            case 'plastik':
                include 'content/manufaktur/supplier-plastik/view/view.php';
                break;
            case 'botol':
                include 'content/manufaktur/supplier-botol/view/view.php';
                break;
            case 'gula-merah':
                include 'content/manufaktur/supplier-gmerah/view/view.php';
                break;
        }
        break;
    case 'order':
        switch($obj) {
            case 'kedelai' :
                include 'content/manufaktur/order-kedelai/view.php';
                break;
            case 'garam':
                include 'content/manufaktur/order-garam/view.php';
                break;
            case 'plastik':
                include 'content/manufaktur/order-plastik/view.php';
                break;
            case 'botol':
                include 'content/manufaktur/order-botol/view.php';
                break;
            case 'gmerah':
                include 'content/manufaktur/order-gmerah/view.php';
                break;
        }
        break;
    case 'po':
        include 'content/manufaktur/po/view/view.php';
        break;
    case '404':
    default:
        include 'content/404.php';
        break;
}