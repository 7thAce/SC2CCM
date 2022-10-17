# SC2CCM
StarCraft 2 Custom Campaign Manager

Starting with the test version of 1.03, the SC2CCM will be open source.
This code is decent.  A lot of similar ideas were not pushed into functions (stuff that repeats for each campaign) due to having to carry around the tags/paths/etc. for each campaign.  
The updater is not.  If you're familiar with making an updater, please let me know/make a pull request.  It's honestly a terrible method but was about the only way I could think to do things at the time.  
In the future, we want to work on a better content distribution method other than the CCM discord server.  I'm hoping it doesn't overwrite what anyone does here.  

Basic idea of how the CCM works:
When a .zip or folder is detected, it finds a metadata.txt file in the subfolders.  If it doesn't have one, the folder is ignored.  
From there, the metadata file provides the CCM the information it needs to properly place the files and folders in the correct location.  
All custom campaigns that appear in the CustomCampaigns folder with an associated metadata.txt file will appear in the dropdowns of the CCM.  
If any subfolder in the CustomCampaigns folder does not contain a metadata.txt file, it will throw the "Unable to find metadata.txt for <folder>" error.  
Switching campaigns is removing the campaign files from the SC2 working directory, checking that all the files removed properly, and then copying the selected mod into the correct folder.  
There are a lot of extra checks that make sure nothing gets out of sync, but sometimes issues do crop up.  The perfect goal would be for the user never to have to open the file explorer (which is done for many of the users of this program).  

Built with C# through .NET Framework version 4.8.

Licensing:
Non-official: The SC2CCM is an open source project, so anyone is free to download the code and run it as their own.  However, publishing versions that impersonate the official CCM is not permitted.  Any distribution of a modified project must include the official copyright notice below.

Copyright (c) 2022 by 7thAce and GiantGrantGames

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
