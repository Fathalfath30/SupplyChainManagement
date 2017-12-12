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
 // For the brave souls who get this far: You are the chosen ones,
 // the valiant knights of programming who toil away, without rest,
 // fixing our most awful code. To you, true saviors, kings of men,
 //
 // I say this: never gonna give you up, never gonna let you down,
 // never gonna run around and desert you. Never gonna make you cry,
 // never gonna say goodbye. Never gonna tell a lie and hurt you.
 //
*/

$data['JADWAL_PRODUKSI'] = array (
    array (
        'TANGGAL_BUAT' => '03 November 2017',
        'MESIN'        => 'Mesin A',
        'STATUS'       => 'Idle',
        'KONDISI'      => 'Excellent',
        'ESTIMASI'     => 'Complete'
    ),
    array (
        'TANGGAL_BUAT' => '04 November 2017',
        'MESIN'        => 'Mesin B',
        'STATUS'       => 'Idle',
        'KONDISI'      => 'Good',
        'ESTIMASI'     => 'Complete'
    ),
    array (
        'TANGGAL_BUAT' => '05 November 2017',
        'MESIN'        => 'Mesin C',
        'STATUS'       => 'Idle',
        'KONDISI'      => 'Bad',
        'ESTIMASI'     => 'Complete'
    ),
    array (
        'TANGGAL_BUAT' => '06 November 2017',
        'MESIN'        => 'Mesin D',
        'STATUS'       => 'On Process',
        'KONDISI'      => 'Excellent',
        'ESTIMASI'     => '8 November 2017 (22.40)'
    )
);

$data['PO_BAHAN_BAKU'] = array (
    array (
        'SUPPLIER'      => 'POKTAN',
        'TANGGAL_PESAN' => '22 September 2017',
        'STOCK'         => '10 Ton',
        'T_HARGA'       => 'Rp. 1.625.000.000',
        'STATUS'        => 'Approved',
        'COLOR'         => 'green'
    ),
    array (
        'SUPPLIER'      => 'PT. Dolphin',
        'TANGGAL_PESAN' => '10 Desember 2017',
        'STOCK'         => '50 Ton',
        'T_HARGA'       => 'Rp. 350.000.000',
        'STATUS'        => 'Not Approved',
        'COLOR'         => 'black'
    ),
    array (
        'SUPPLIER'      => 'PT. Anugrah',
        'TANGGAL_PESAN' => '10 Desember 2017',
        'STOCK'         => '70 Ton',
        'T_HARGA'       => 'Rp. 2.560.000.000',
        'STATUS'        => 'Cancelled',
        'COLOR'         => 'red'
    ),
);

$data['PO_DISTRIBUTOR'] = array (
    array (
        'DISTRIBUTOR' => 'PT. Jaya Utama Santikah',
        'TANGGAL'     => '22 November 2017',
        'STOCK'       => '4 Ton',
        'ESTIMASI'    => '22 Desember 2017',
        'STATUS'      => 'Dalam Proses',
        'COLOR'       => 'blue'
    ),
    array (
        'DISTRIBUTOR' => 'PT. Sentosa',
        'TANGGAL'     => '10 November 2017',
        'STOCK'       => '3.5 Ton',
        'ESTIMASI'    => '03 Desember 2017',
        'STATUS'      => 'Complete',
        'COLOR'       => 'green'
    ),
    array (
        'DISTRIBUTOR' => 'Kenkyuukai',
        'TANGGAL'     => '10 Oktober 2017',
        'STOCK'       => '8 Ton',
        'ESTIMASI'    => '10 Desember 2017',
        'STATUS'      => 'Complete',
        'COLOR'       => 'green'
    ),
    array (
        'DISTRIBUTOR' => 'PT. Melia Soman',
        'TANGGAL'     => '03 Dsember 2017',
        'STOCK'       => '2 Ton',
        'ESTIMASI'    => '17 Desember 2017',
        'STATUS'      => 'Delayed',
        'COLOR'       => 'red'
    ),
);