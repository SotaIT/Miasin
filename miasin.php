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
 * php version 7.3
 
 * @category Plugins
 * @package  Miasin
 * @author   Aram Aramyan <aram_aramyan@mail.ru>
 * @license  GPL2 https://github.com/SotaIT/Miasin/blob/master/LICENSE
 * @link     http://miasin.org/
 */


add_action('init', 'miasin_init');


/**
 * Init
 *
 * @return void
 */
function Miasin_init()
{
    // hide admin bar 
    if (!current_user_can('manage_options')) {
        add_filter('show_admin_bar', '__return_false');
    }
}