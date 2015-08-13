<?php namespace App;
class Page{
  private $content;
  private $pageNumber;

  public function __construct($content, $pageNumber){
    $this->content = $content;
    $this->pageNumber = $pageNumber;
  }
  
  public function getHtmlContent(){
    return '<h1>'.$this->getPageHeader().'</h1>'.'<p>'.$this->content.'</p>';
  }

  public function getRawContent(){
    return $this->getPageHeader().'\\n'.$this->content.'\\n';
  }

  private function getPageHeader(){
    return 'Content of page #'.$this->pageNumber;
  }
}