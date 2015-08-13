<?php namespace App;
class Book{
  private $id;
  private $name;
  private $author;
  private $type; //1 Paper, 2 Kindle
  private $listPages;

  public function __construct($id,$name,$author,$type,$listPages){
    $this->id = $id;
    $this->name = $name;
    $this->author = $author;
    $this->type = $type;
    $this->listPages = $listPages;
  }

  public function getName(){
    return $this->name;
  }

  public function getAuthor(){
    return $this->author;
  }

  public function getBookSize(){
    return count($this->listPages);
  }

  
}