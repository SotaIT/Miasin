<?php
/**
 * Plugin Name:       Miasin
 * Plugin URI:        https://miasin.org/
 * Description:       UGC for WordPress
 * Version:           1.0.0
 * Author:            Aram Aramyan
 * License:           GPL2
 * Text Domain:       miasin
 * Domain Path:       /languages
 */

 
// hide admin bar 
if (!current_user_can('manage_options')) {
    add_filter('show_admin_bar', '__return_false');
}