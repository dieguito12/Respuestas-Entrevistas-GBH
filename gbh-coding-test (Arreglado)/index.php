<?php
error_reporting(E_ALL | E_STRICT);
ini_set('display_errors',1);
function __autoload($class){
  $parts = explode('\\', $class);
  require end($parts) . '.php';
}
use \App;
$bookReader = new App\BookReader();
$bookReader->readSpecificBook(0); //Read 1 book
$bookReader->readAllBooks(); //Read all available books
$bookReader->readSpecificBook(3); //Read nonexistent book