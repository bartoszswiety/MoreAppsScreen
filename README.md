<article id="post-239" class="clearfix post-239 post type-post status-publish format-standard has-post-thumbnail hentry category-ios-dev category-protfolio category-programming category-uncategorized category-unity3d tag-c tag-global tag-ios-moreapps tag-moreapps tag-moreappsscreen tag-remotely tag-unity3d-2 tag-unity3d-more tag-unity3d-moreappsscreen tag-xml">






<div class="post-content">

<time datetime="2015-09-17" class="post-date">September 17, 2015</time>

<h1 class="post-title">
<a href="https://bartoszswiety.com/blog/2015/09/17/remotely-customisable-moreapps-screen/" title="Dynamic MoreApps screen.">Dynamic MoreApps screen.</a>
</h1>

<p class="post-meta">
<span class="post-author"><a href="https://bartoszswiety.com/blog/author/bartoszswiety/" title="Posts by bartoszswiety" rel="author">bartoszswiety</a></span>

<span class="post-category"><a href="https://bartoszswiety.com/blog/category/ios-dev/" rel="tag">iOS Dev</a>, <a href="https://bartoszswiety.com/blog/category/protfolio/" rel="tag">Portfolio</a>, <a href="https://bartoszswiety.com/blog/category/programming/" rel="tag">programming</a>, <a href="https://bartoszswiety.com/blog/category/uncategorized/" rel="tag">Uncategorized</a>, <a href="https://bartoszswiety.com/blog/category/unity3d/" rel="tag">Unity3D</a></span>
<span class="post-tag"><a href="https://bartoszswiety.com/blog/tag/c/" rel="tag">C#</a>, <a href="https://bartoszswiety.com/blog/tag/global/" rel="tag">Global</a>, <a href="https://bartoszswiety.com/blog/tag/ios-moreapps/" rel="tag">iOS MoreApps</a>, <a href="https://bartoszswiety.com/blog/tag/moreapps/" rel="tag">MoreApps</a>, <a href="https://bartoszswiety.com/blog/tag/moreappsscreen/" rel="tag">MoreAppsScreen</a>, <a href="https://bartoszswiety.com/blog/tag/remotely/" rel="tag">Remotely</a>, <a href="https://bartoszswiety.com/blog/tag/unity3d-2/" rel="tag">unity3d</a>, <a href="https://bartoszswiety.com/blog/tag/unity3d-more/" rel="tag">Unity3d More</a>, <a href="https://bartoszswiety.com/blog/tag/unity3d-moreappsscreen/" rel="tag">Unity3D MoreAppsScreen</a>, <a href="https://bartoszswiety.com/blog/tag/xml/" rel="tag">XML</a></span>
<span class="post-comment">
<a href="https://bartoszswiety.com/blog/2015/09/17/remotely-customisable-moreapps-screen/#respond">0 Comments</a>                    </span>
</p>
<!-- /.post-meta -->

<div id="thumb">
<a href="https://bartoszswiety.com/blog/2015/09/17/remotely-customisable-moreapps-screen/" title="Dynamic MoreApps screen.">
<img width="858" height="172" src="https://bartoszswiety.com/blog/wp-content/uploads/2015/09/hello.png" class="attachment-large size-large wp-post-image" alt="" srcset="https://bartoszswiety.com/blog/wp-content/uploads/2015/09/hello.png 1000w, https://bartoszswiety.com/blog/wp-content/uploads/2015/09/hello-300x60.png 300w" sizes="(max-width: 858px) 100vw, 858px">            </a>
</div>

<p>Only good marketing strategy allows us to achieve success in mobile apps industry. Honestly this part of development wasn’t really important for me, but after realising some apps I understood that all my products have to be connected into one big piece. Unfortunately adding some “advertisement” banners to all my products with every new app realising seemed as really painful work. That’s why I had to make some service which allows us set up MoreAppsScreen on all my apps for iOS without any building in just one click.</p>
<p><span id="more-239"></span></p>
<p><img class="wp-image-243 aligncenter" src="http://bartoszswiety.com/blog/wp-content/uploads/2015/09/Screen-Shot-2015-09-17-at-14.23.33.png" alt="Screen Shot 2015-09-17 at 14.23.33" width="264" height="396" srcset="https://bartoszswiety.com/blog/wp-content/uploads/2015/09/Screen-Shot-2015-09-17-at-14.23.33.png 622w, https://bartoszswiety.com/blog/wp-content/uploads/2015/09/Screen-Shot-2015-09-17-at-14.23.33-200x300.png 200w" sizes="(max-width: 264px) 100vw, 264px"></p>
<h1></h1>
<h1></h1>
<h2>Ok, but what is it?</h2>
<p style="padding-left: 30px;">Idea was really simple, I just wanted to have some screen with buttons which are based on data from my server and that’s exactly how it works!</p>
<h2>How does it work?</h2>
<p style="padding-left: 30px;">Screen setting is based on XML data from server. According to data code sets &nbsp;header text and buttons’s image. Of course in case when network is unreachable by our device system loads last version from memory. From the experience I can say that data are not really heavy. Simple xml with 4 buttons takes about 115 kb, so our server shouldn’t be under big load.</p>
<h2>How can I personalise this screen?</h2>
<p style="padding-left: 30px;">That’s really easy, &nbsp;I made special screen in UnityEditorGUI which allows us to generate XML in just few click! The best in my system is that We can add screen to Unity3D project with just one line of the code!</p>
<p style="padding-left: 30px;"><a href="http://bartoszswiety.com/blog/wp-content/uploads/2015/09/Screen-Shot-2015-09-17-at-14.45.24.png"><img class="aligncenter size-full wp-image-244" src="http://bartoszswiety.com/blog/wp-content/uploads/2015/09/Screen-Shot-2015-09-17-at-14.45.24.png" alt="Screen Shot 2015-09-17 at 14.45.24" width="595" height="347" srcset="https://bartoszswiety.com/blog/wp-content/uploads/2015/09/Screen-Shot-2015-09-17-at-14.45.24.png 595w, https://bartoszswiety.com/blog/wp-content/uploads/2015/09/Screen-Shot-2015-09-17-at-14.45.24-300x174.png 300w" sizes="(max-width: 595px) 100vw, 595px"></a></p>
<h2>That’s seems really cool, when can I get beta version?</h2>
<p style="padding-left: 30px;">I was thinking about realising that on Unity Asset Store, but for a while it’s&nbsp;available totally for free under this link. I didn’t have much time for creating special instructions, but of course you can contact me on the skype(bswiety) for some help!</p>
<h2 style="padding-left: 30px;"><a href="https://www.dropbox.com/s/2hn4ieuagl8s1ot/MoreApps001.unitypackage?dl=0">Here it is!</a></h2>

<span class="edit-button">[<a class="post-edit-link" href="https://bartoszswiety.com/blog/wp-admin/post.php?post=239&amp;action=edit">Edit</a>]</span>        
</div>
<!-- /.post-content -->


</article>
