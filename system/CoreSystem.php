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

class CoreSystem {
    private $UrlConfig;
    private $DirConfig;

    public function __construct ($config) {
        $this->UrlConfig = $config['BASE_URL'];
        $this->DirConfig = $config['DIRECTORY'];
    }

    public function GetCSS ($path) {
        if ( !is_array($path) ) {
            echo sprintf("<link rel='stylesheet' type='text/css' href='%s'>", $this->base_url($path));
        } else {
            for ( $i = 0; $i < count($path); $i++ ) {
                echo sprintf("<link rel='stylesheet' type='text/css' href='%s'>", $this->base_url($path[$i]));
            }
        }
    }

    public function GetJS ($path) {

        if ( !is_array($path) ) {
            echo sprintf("<script type='text/javascript' src='%s'></script>", $this->base_url($path));
        } else {
            for ( $i = 0; $i < count($path); $i++ ) {
                echo sprintf("<script type='text/javascript' src='%s'></script>", $this->base_url($path[$i]));
            }
        }
    }

    public function base_url ($url = "") {
        return sprintf("%s%s", $this->UrlConfig, $url);
    }
}