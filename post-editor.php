<?php
/**
 * Post editor class
 
 * PHP version 7.3
 
 * @category Plugins
 * @package  Miasin
 * @author   Aram Aramyan <aram_aramyan@mail.ru>
 * @license  GPL2 https://github.com/SotaIT/Miasin/blob/master/LICENSE
 * @link     http://miasin.org/
 */

class Miasin_Edit_Post
{
    /**
     * Constructor
     */
    function __construct() 
    {
        add_shortcode('miasin_editpost', array($this, 'shortcode'));
    }

    /**
     * Handles the edit post shortcode
     *
     * @return void
     */
    function shortcode() 
    {
        echo 'test';
    }
}