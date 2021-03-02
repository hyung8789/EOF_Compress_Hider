# EOF Compress Hider
<img src="./res/icons8-hide-100.png"><br></br>
A simple implementation of Steganography using EOF (End-of-file) method


## < How it works >
The data for concealment is compressed and inserted after the EOF(End-of-file) tag in the image file.
All text or binary data behind the EOF tag in the image file is ignored when the image is viewed through a web browser (If the image file is uploaded to the Internet) or when the image is viewed directly using a photo editing application.
Thus, although it appears to be a superficially normal image file, hidden data can be accessed because the commercial decompression utility recognizes the compression header upon opening after changing the extension to '.zip'.

<b>- Cover Image : Cover image for camouflage with normal image file.</b><br>
<b>- Target : The data for concealment.</b><br>
<b>- Output File : File combined with Cover Image + Target.</b><br>


## < Features >

- Support Type for Cover Image And Output File : JPEG (*.jpg,*.jpeg,*.jpe,*.jfif), PNG (*.png), BMP (*.bmp,*.dib), GIF (*.gif)
- Support Type for Target : All file types (.*) or Folder
- Support compress Target with Password


## < Demo & Screenshot >
<img src="./demo/demo1.png"><br></br>
<img src="./demo/demo2.png"><br></br>
<img src="./demo/result.zip.jpg"><br></br>

Above Image has hidden data (Compressed with Password : 1234)
You can open it with decompression utility after changing the extension to '.zip'.


## < System Requirement >
- .Net Framework 4.8


## < Download >


## < License >
[This application is licensed under the MIT License.](https://github.com/hyung8789/EOF_Compress_Hider/blob/master/LICENSE)</b><br></br>
Font used in this application is D2 Coding.<br>
Copyright (c) 2015, NAVER Corporation (http://www.navercorp.com)<br>
SIL Open Font License, Version 1.1 : https://github.com/naver/d2codingfont/wiki/Open-Font-License<br></br>
