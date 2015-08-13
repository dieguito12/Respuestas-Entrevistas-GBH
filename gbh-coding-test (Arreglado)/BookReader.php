<?php namespace App;
class BookReader{
  private $myBooks;

  public function __construct(){
    $this->myBooks = null;
  }

  private function readBook($theBook){
    echo 'I\'m currently reading: '.$theBook->getName().'<br/>';
    for($i = 0; $i < $theBook->getBookSize(); $i++){
      $theBook->setCurrentPage($i);
      echo $theBook->readPage();
    }
    echo 'I just finished reading '.$theBook->getName().', what a great book!<br/>';
  }

  public function readSpecificBook($id){
    if(!$this->loadBook($id)){
      echo 'Book not found';
      return;
    }
    $this->readBook($this->myBooks[$id]);
  }

  public function readAllBooks(){
    $jsonData = json_decode(file_get_contents('./Data/books.json'));
    $listObjBooks = [];
    foreach($jsonData->books as $index => $theBook){
      $myListPages = [];
      foreach($theBook->pages as $thePage){
        $myListPages[] = new Page(
          $thePage->content,
          $thePage->pageNumber
        );
      }
      $listObjBooks[$index] = new Book(
        $index,
        $theBook->name,
        $theBook->author,
        $theBook->type,
        $myListPages
      );
    }
    foreach($listObjBooks; as $theBook){
      $this->readBook($theBook);
    }
  }

  private function loadBook($id){
    if(!isset($this->myBooks[$id])){
      $this->myBooks[$id] = self::getBookById($id);
    }
    return  $this->myBooks[$id];
  }


  private static function findSingleJsonBook($id){
    $jsonData = json_decode(file_get_contents('./Data/books.json'));
    if(isset($jsonData->books[$id])){
      return $jsonData->books[$id];
    }
    return null;
  }

  public static function getBookById($id){
    $theBook = self::findSingleJsonBook($id);
    if(!$theBook){
      return null;
    }
    $myListPages = [];
    foreach($theBook->pages as $thePage){
      $myListPages[] = new Page(
        $thePage->content,
        $thePage->pageNumber
      );
    }
    return new Book(
      $id,
      $theBook->name,
      $theBook->author,
      $theBook->type,
      $myListPages
    );
  }

  public function readPage($pageNumber, $book_id){

    $theBook = getBookById($book_id);

    $theBook->listPages[$pageNumber]);
    switch($theBook->type){
      case 1:
        return $theBook->listPages[$pageNumber]->getHtmlContent();
      break;
      case 2:
        return $theBook->listPages[$pageNumber]->getRawContent();
      break;
    }
  }
}