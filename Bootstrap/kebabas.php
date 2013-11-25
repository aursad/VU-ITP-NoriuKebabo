<!DOCTYPE html>
<html>
  <head>
    <title>Noriu kebabo!</title>
	<meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet" media="screen">

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="../../assets/js/html5shiv.js"></script>
      <script src="../../assets/js/respond.min.js"></script>
    <![endif]-->
  </head>
  <style>
a:hover, a:visited, a:link, a:active
{
	color: #000000;
    text-decoration: none;
}
  </style>
  <body>

<nav class="navbar navbar-default" role="navigation">
  <!-- Brand and toggle get grouped for better mobile display -->
  <div class="navbar-header">
    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
      <span class="sr-only">Toggle navigation</span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
    </button>
	<a class="navbar-brand" href="index.php"> NORIU Kebabo!</a>
  </div>

  <!-- Collect the nav links, forms, and other content for toggling -->
  <div class="collapse navbar-collapse navbar-ex1-collapse">
    <ul class="nav navbar-nav navbar-right">
      <li><a href="#prideti">Pridėti vietą</a></li>
	  <li><a data-toggle="modal" href="#myModal">Prisijungti</a></li>
    </ul>
  </div><!-- /.navbar-collapse -->
</nav>
	  
	  <div class="container">
		  <div class="row">
<div class="col-md-4">
<div class="panel panel-success">
  <div class="panel-heading">
    <h3 class="panel-title">TOP 5</h3>
  </div>
  <div class="panel-body">
    <ul class="media-list">
					<li class="media">
						<a class="pull-left" href="#">
						  <img class="media-object" src="confube.png" alt="...">
						  
						</a>
						<div class="media-body">
						  <h4 class="media-heading">Kebabine 1 <span class="label label-info pull-right">5 <span class="glyphicon glyphicon-star"></span></span></h4>
						  Trakų g. 0, Vilnius
						</div>
					</li>
					<li class="media">
						<a class="pull-left" href="#">
						  <img class="media-object" src="confube.png" alt="...">
						</a>
						<div class="media-body">
						  <h4 class="media-heading">Kebabine 2 <span class="label label-info pull-right">5 <span class="glyphicon glyphicon-star"></span></span></h4>
						 Trakų g. 0, Vilnius
						</div>
					</li>
					<li class="media">
						<a class="pull-left" href="#">
						  <img class="media-object" src="confube.png" alt="...">
						</a>
						<div class="media-body">
						  <h4 class="media-heading">Kebabine 3 <span class="label label-info pull-right">4.9 <span class="glyphicon glyphicon-star"></span></span></h4>
						  Trakų g. 0, Vilnius
						</div>
					</li>
					<li class="media">
						<a class="pull-left" href="#">
						  <img class="media-object" src="confube.png" alt="...">
						</a>
						<div class="media-body">
						  <h4 class="media-heading">Kebabine 4 <span class="label label-info pull-right">4.8 <span class="glyphicon glyphicon-star"></span></span></h4>
						  Trakų g. 0, Vilnius
						</div>
					</li>
					<li class="media">
						<a class="pull-left" href="#">
						  <img class="media-object" src="confube.png" alt="...">
						</a>
						<div class="media-body">
						  <h4 class="media-heading">Kebabine 5 <span class="label label-info pull-right">4.7 <span class="glyphicon glyphicon-star"></span></span></h4>
						  Trakų g. 0, Vilnius
						</div>
					</li>
				</ul>
  </div>
</div>
<div class="panel panel-success">
  <div class="panel-heading">
    <h3 class="panel-title">NAUJAUSIOS</h3>
  </div>
  <div class="panel-body">
    <ul class="media-list">
					<li class="media">
						<a class="pull-left" href="#">
						  <img class="media-object" src="confube.png" alt="...">
						  
						</a>
						<div class="media-body">
						  <h4 class="media-heading">Kebabine 6 <span class="label label-info pull-right">0 <span class="glyphicon glyphicon-star"></span></span></h4>
						  Trakų g. 0, Vilnius
						</div>
					</li>
					<li class="media">
						<a class="pull-left" href="#">
						  <img class="media-object" src="confube.png" alt="...">
						</a>
						<div class="media-body">
						  <h4 class="media-heading">Kebabine 7 <span class="label label-info pull-right">0 <span class="glyphicon glyphicon-star"></span></span></h4>
						  Trakų g. 0, Vilnius
						</div>
					</li>
				</ul>
  </div>
</div>
</div>
			<hr class="hidden-lg">
			<div class="col-md-8">
			<div class="panel panel-info">
  <div class="panel-heading">
    <h3 class="panel-title">Kebabine 1 <span class="label label-info pull-right">3,7 <span class="glyphicon glyphicon-star"></span></span></h3>
  </div>
  <div class="panel-body">
   <div id="carousel-example-generic" class="carousel slide bs-docs-carousel-example">
        <ol class="carousel-indicators">
          <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
          <li data-target="#carousel-example-generic" data-slide-to="1"></li>
          <li data-target="#carousel-example-generic" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
          <div class="item active">
		  <img src="https://fbcdn-sphotos-c-a.akamaihd.net/hphotos-ak-ash3/526605_172210136266336_103764831_n.jpg" alt="...">
          </div>
          <div class="item">
            <img src="https://fbcdn-sphotos-g-a.akamaihd.net/hphotos-ak-ash3/598794_165952236892126_1010369920_n.png" alt="...">
          </div>
          <div class="item">
            <img src="https://fbcdn-sphotos-f-a.akamaihd.net/hphotos-ak-frc3/549790_164837817003568_1460856220_n.png" alt="...">
          </div>
		  <div class="item">
            <img src="https://fbcdn-sphotos-d-a.akamaihd.net/hphotos-ak-ash3/601964_164837767003573_1927825804_n.png" alt="...">
          </div>
        </div>
        <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
          <span class="icon-prev"></span>
        </a>
        <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
          <span class="icon-next"></span>
        </a>
      </div><br/>
					<p>SUPER KEBAI - lankstomi tik iš aukščiausios kokybės produktų: nemaltos natūralios mėsytės (kiaulienos sprandinės, vištienos krūtinėlių), kuri būna kruopščiai įtrinama prieskoniais, suveriama ant iešmo ir skrudinama atviroje liepsnoje.
 
SUPER KEBUOSE gausu šviežių daržovių: prisirpusių vengriškų pomidorų, traškių agurkų, pekino salotų, spec. receptūra marinuotų agurkėlių bei Jūsų papildomai pasirenkamų nemokamų priedų.
 
SUPER KEBŲ padažai unikalūs, gaminami tik iš aukščiausios kokybės produktų ne rečiau kaip du kartus per dieną, kad išliktų kuo šviežesni ir aromatingesni. Prancūziškos bulvytės, patiekiamos prie SUPERKOMPLEKSŲ, taip pat yra lyderės tarp savo kolegių - PREMIUM rūšies ir kepamos tik tyrame saulėgrąžų aliejuje, plius pagardinamos anksčiau minėtais padažais.</p>
					
					<hr>
					<div class="alert alert-success">Atsiliepimai
					</div>
					<div class="row">
						<div class="col-md-6">
						<li class="media">
						<a class="pull-left" href="#">
						  <h2 class="pull-center">3,7</h2>
						  <span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span>
						</a>
						  <ul class="list-unstyled ">
							<li><span class="glyphicon glyphicon-star">5 - 2</li>
							<li><span class="glyphicon glyphicon-star">4 - 0</li>
							<li><span class="glyphicon glyphicon-star">3 - 0</li>
							<li><span class="glyphicon glyphicon-star">2 - 0</li>
							<li><span class="glyphicon glyphicon-star">1 - 1</li>
						  </ul>
						</div>
					</li>
						<div class="col-md-6">
						<blockquote>
  <p>Man čia labai patiko. Skanu.</p>
  <small>Vardenis Pavardenis <cite title="Ivertinimas"><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span>
						</cite></small>
</blockquote>

						</div>
					</div>
					<div class="alert alert-success">Dalinkis
						<img src="http://m.delfi.lt/misc/crs/mobile/img/follow_ico_fb.png" alt="Facebook" class="img-rounded pull-right">
						<img src="http://m.delfi.lt/misc/crs/mobile/img/follow_ico_twit.png" alt="Twitter" class="img-rounded pull-right">
						<img src="http://m.delfi.lt/misc/crs/mobile/img/follow_ico_rss.png" alt="RSS" class="img-rounded pull-right">
					</div>
					<div class="alert alert-success">Komentarai
					</div>
<blockquote>
  <p>Skanu</p>
    <small>Vardenis Pavardenis <cite title="Ivertinimas"><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star"></span>
						</cite></small>
</blockquote>
<blockquote>
  <p>Skanu</p>
   <small>Vardenis Pavardenis <cite title="Ivertinimas"><span class="glyphicon glyphicon-star"></span>
						</cite></small>
</blockquote>
					<p><a class="btn btn-primary btn-lg">Skaityti daugiau...</a></p>
  </div>
</div>
			</div>
		</div>
    </div>
	 <hr>
	 <div id="footer">
      <div class="container">
		<div class="row">
			  <div class="col-md-4">
				  <p>Sek mumis:</p>
				  <img src="http://m.delfi.lt/misc/crs/mobile/img/follow_ico_fb.png" alt="Facebook" class="img-rounded">
				  <img src="http://m.delfi.lt/misc/crs/mobile/img/follow_ico_twit.png" alt="Twitter" class="img-rounded">
				  <img src="http://m.delfi.lt/misc/crs/mobile/img/follow_ico_rss.png" alt="RSS" class="img-rounded">
			  </div>
			  <div class="col-md-4">
				<ul class="list-unstyled">
					<li><a href="#kas">Kas yra "Noriu kebabo"?</a></li> 
					<li><a href="#privatumas">Privatumas</a></li> 
					<li><a href="#reklama">Reklama</a></li>
			   </ul>
			  </div>
			  <div class="col-md-4">
				<ul class="list-unstyled ">
					<li>© 2013 Aurimas</li> 
					<li><a href="#teises">Visos teisės saugomos.</a></li> 
					<li><a href="#atsakomybe">Atsakomybės apribojimas. </a></li>
			   </ul>
			  </div>
		</div>
      </div>
    </div> 
	 <!-- Modal -->
  <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
          <h4 class="modal-title">Prisijungimas prie sistemos</h4>
        </div>
        <div class="modal-body">
           <form class="form-horizontal" role="form">
  <div class="form-group">
    <div class="col-lg-12">
      <input type="email" class="form-control" id="inputEmail1" placeholder="El. paštas">
    </div>
  </div>
  <div class="form-group">
    <div class="col-lg-12">
      <input type="password" class="form-control" id="inputPassword1" placeholder="Slaptažodis">
    </div>
  </div>
  <div class="form-group">
    <div class="col-lg-4">
      <div class="checkbox">
        <label>
          <input type="checkbox"> Prisiminti mane
        </label>
      </div>
    </div>
  </div>
  </label>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-primary">Prisijungti</button>
		  <button type="button" class="btn btn-default" data-dismiss="modal">Uždaryti</button>
        </div>
      </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
  </div><!-- /.modal -->
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="//code.jquery.com/jquery.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
  </body>
</html>