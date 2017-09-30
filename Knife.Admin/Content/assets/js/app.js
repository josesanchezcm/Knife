/**
 * @name AceApp
 * @description
 * # AceApp
 *
 * Main module of the application.
 */
var app = angular
	.module('AceApp', [
		'ngAnimate',
		'ngResource',
		'ngSanitize',
		'ngTouch',
		//'angular-loading-bar',
		'oc.lazyLoad',
		'ui.bootstrap',
		'ui.router',
		'ace.directives',
		'ngStorage'
	])
	.config(function ($stateProvider, $urlRouterProvider, $ocLazyLoadProvider/**, cfpLoadingBarProvider*/) {
		//cfpLoadingBarProvider.includeSpinner = true;

		$urlRouterProvider.otherwise('/dashboard');

		$stateProvider
			.state('dashboard', {
				url: '/dashboard',
				title: 'Dashboard',
				icon: 'fa fa-tachometer',

				templateUrl: 'Content/assets/views/pages/dashboard.html',
				controller: 'DashboardCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([{
							name: 'angular-flot',
							serie: true,
							files: ['../Content/components/Flot/jquery.flot.js',
								'../Content/components/Flot/jquery.flot.pie.js',
								'../Content/components/Flot/jquery.flot.resize.js',
								'../Content/components/angular-flot/angular-flot.js']
						},
						{
							name: 'easypiechart',
							files: ['../Content/components/_mod/easypiechart/angular.easypiechart.js']
						},
						{
							name: 'sparkline',
							files: ['../Content/components/jquery.sparkline/index.js']
						},
						{
							name: 'AceApp',
							files: ['../Content/assets/js/controllers/pages/dashboard.js']
						}]);
					}]
				}
			})


			.state('ui', {
				'abstract': true,
				//url: '/ui',
				title: 'UI & Elements',
				template: '<ui-view/>',

				icon: 'fa fa-desktop'
			})
			.state('ui.typography', {
				url: '/typography',
				title: 'Typography',

				templateUrl: 'Content/assets/views/pages/typography.html',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([{
							name: 'prettify',
							files: ['../Content/components/_mod/google-code-prettify/prettify.css', '../Content/components/google-code-prettify/src/prettify.js']
						}]);
					}]
				}
			})
			.state('ui.elements', {
				url: '/elements',
				title: 'Elements',

				templateUrl: 'Content/assets/views/pages/elements.html',
				controller: 'ElementsCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([{
							name: 'bootbox',
							files: ['../Content/components/bootbox.js/bootbox.js']
						},
						{
							name: 'easypiechart',
							files: ['../Content/components/_mod/easypiechart/angular.easypiechart.js']
						},
						{
							name: 'gritter',
							files: ['../Content/components/jquery.gritter/js/jquery.gritter.js']
						},
						{
							serie: true,
							name: 'ui.slider',
							files: ['../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.js', '../Content/components/jqueryui-touch-punch/jquery.ui.touch-punch.js', '../Content/components/angular-ui-slider/src/slider.js']
						},
						{
							serie: true,
							name: 'angularSpinner',
							files: ['../Content/components/spin.js/spin.js', '../Content/components/spin.js/jquery.spin.js', '../Content/components/angular-spinner/angular-spinner.js']
						},
						{
							name: 'AceApp',
							files: ['../Content/assets/js/controllers/pages/elements.js']
						},
						{
							name: 'AceApp',
							insertBefore: '#main-ace-style',
							files: [
								'../Content/components/jquery.gritter/css/jquery.gritter.css',
								'../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.css',
								'../Content/assets/css/pages/elements.css'
							]
						}]);
					}]
				}
			})
			.state('ui.buttons', {
				url: '/buttons',
				title: 'Buttons',

				templateUrl: 'Content/assets/views/pages/buttons.html',
				controller: 'ButtonsCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/buttons.js']
							}]);
					}]
				}
			})
			.state('ui.content-slider', {
				url: '/content-slider',
				title: 'Content Slider',

				templateUrl: 'Content/assets/views/pages/content-slider.html',
				controller: 'ContentSliderCtrl',
				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([{
							name: 'ngAside',
							files: ['../Content/components/angular-aside/dist/js/angular-aside.js']
						},
						{
							name: 'AceApp',
							files: ['../Content/assets/js/controllers/pages/content-slider.js']
						},
						{
							name: 'AceApp',
							insertBefore: '#main-ace-style',
							files: ['../Content/components/angular-aside/dist/css/angular-aside.css']
						}]);
					}]
				}
			})
			.state('ui.treeview', {
				url: '/treeview',
				title: 'Treeview',

				templateUrl: 'Content/assets/views/pages/treeview.html',
				controller: 'TreeviewCtrl',
				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([{
							name: 'treeControl',
							files: ['../Content/components/angular-tree-control/angular-tree-control.js']
						},
						{
							name: 'AceApp',
							files: ['../Content/assets/js/controllers/pages/treeview.js']
						}]);
					}]
				}
			})
			.state('ui.nestable-list', {
				url: '/nestable-list',
				title: 'Nestable Lists',

				templateUrl: 'Content/assets/views/pages/nestable-list.html',
				controller: 'NestableCtrl',
				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([{
							name: 'ngNestable',
							files: ['../Content/components/_mod/jquery.nestable/jquery.nestable.js', '../Content/components/angular-nestable/src/angular-nestable.js']
						},
						{
							name: 'AceApp',
							files: ['../Content/assets/js/controllers/pages/nestable.js']
						}]);
					}]
				}
			})



			.state('table', {
				url: '/table',
				title: 'Tables',
				icon: 'fa fa-list',

				templateUrl: 'Content/assets/views/pages/table.html',
				controller: 'TableCtrl',
				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								serie: true,
								name: 'dataTables',
								files: ['../Content/components/datatables/media/js/jquery.dataTables.js', '../Content/components/_mod/datatables/jquery.dataTables.bootstrap.js', '../Content/components/angular-datatables/dist/angular-datatables.js']
							},
							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/table.js']
							}]);
					}]
				}
			})


			.state('form', {
				'abstract': true,
				//url: '/form',
				title: 'Forms',
				template: '<ui-view/>',
				icon: 'fa fa-pencil-square-o'
			})
			.state('form.form-elements', {
				url: '/form-elements',
				title: 'Form Elements',

				templateUrl: 'Content/assets/views/pages/form-elements.html',
				controller: 'FormCtrl',
				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								serie: true,
								name: 'ui.slider',
								files: ['../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.js', '../Content/components/jqueryui-touch-punch/jquery.ui.touch-punch.js', '../Content/components/angular-ui-slider/src/slider.js']
							},

							{
								name: 'text_area',
								files: ['../Content/components/jquery-inputlimiter/jquery.inputlimiter.js', '../Content/components/angular-elastic/elastic.js']
							},

							{
								name: 'mask',
								files: ['../Content/components/angular-ui-mask/dist/mask.js']
							},

							{
								name: 'chosen',
								files: ['../Content/components/chosen/chosen.jquery.js', '../Content/components/angular-chosen-localytics/chosen.js']
							},

							{
								name: 'spinner',
								files: ['../Content/components/fuelux/js/spinbox.js']
							},

							{
								name: 'datepicker',
								files: ['../Content/components/bootstrap-datepicker/dist/js/bootstrap-datepicker.js']
							},

							{
								serie: true,
								name: 'daterange',
								files: ['../Content/components/moment/moment.js', '../Content/components/bootstrap-daterangepicker/daterangepicker.js', '../Content/components/angular-daterangepicker/js/angular-daterangepicker.js']
							},

							{
								name: 'timepicker',
								files: ['../Content/components/bootstrap-timepicker/js/bootstrap-timepicker.js']
							},

							{
								serie: true,
								name: 'datetimepicker',
								files: ['../Content/components/moment/moment.js', '../Content/components/eonasdan-bootstrap-datetimepicker/src/js/bootstrap-datetimepicker.js']
							},

							{
								name: 'colorpicker',
								files: ['../Content/components/angular-bootstrap-colorpicker/js/bootstrap-colorpicker-module.js', '../Content/components/angular-bootstrap-colorpicker/css/colorpicker.css']
							},

							{
								name: 'knob',
								files: ['../Content/components/jquery-knob/js/jquery.knob.js', '../Content/components/angular-knob/src/angular-knob.js']
							},


							{
								serie: true,
								name: 'typeahead',
								files: ['../Content/components/typeahead.js/dist/bloodhound.js', '../Content/components/typeahead.js/dist/typeahead.jquery.js', '../Content/components/angular-typeahead/angular-typeahead.js']
							},

							{
								name: 'multiselect',
								files: ['../Content/components/angular-bootstrap-multiselect/angular-bootstrap-multiselect.js']
							},

							{
								name: 'select2',
								files: ['../Content/components/ui-select/dist/select.js']
							},


							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/form-elements.js']
							},


							{
								name: 'AceApp',
								insertBefore: '#main-ace-style',
								files: [
									'../Content/components/chosen/chosen.css',
									'../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.css',
									'../Content/components/eonasdan-bootstrap-datetimepicker/build/css/bootstrap-datetimepicker.css',
									'../Content/components/bootstrap-timepicker/css/bootstrap-timepicker.css',
									'../Content/components/bootstrap-datepicker/dist/css/bootstrap-datepicker3.css',
									'../Content/components/bootstrap-daterangepicker/daterangepicker.css',
									'../Content/components/select2.v3/select2.css'
								]
							}]);
					}]
				}
			})
			.state('form.form-wizard', {
				url: '/form-wizard',
				title: 'Form Wizard',

				templateUrl: 'Content/assets/views/pages/form-wizard.html',
				controller: 'WizardCtrl',
				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([{
							name: 'ngMessages',
							files: ['../Content/components/angular-messages/angular-messages.js']
						},

						{
							name: 'wizard',
							files: ['../Content/components/angular-wizard/dist/angular-wizard.js']
						},

						{
							name: 'mask',
							files: ['../Content/components/angular-ui-mask/dist/mask.js']
						},

						{
							name: 'chosen',
							files: ['../Content/components/chosen/chosen.jquery.js', '../Content/components/angular-chosen-localytics/chosen.js']
						},

						{
							name: 'AceApp',
							files: ['../Content/assets/js/controllers/pages/form-wizard.js']
						},
						{
							name: 'AceApp',
							insertBefore: '#main-ace-style',
							files: ['../Content/components/chosen/chosen.css']
						}]);
					}]
				}

			})
			.state('form.wysiwyg', {
				url: '/wysiwyg',
				title: 'Wysiwyg & Markdown',

				templateUrl: 'Content/assets/views/pages/wysiwyg.html',
				controller: 'WysiwygCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								name: 'wysiwyg',
								serie: true,
								files: [
									'../Content/components/bootstrap/js/dropdown.js',//for wysiwyg dropdowns
									'../Content/components/jquery.hotkeys/index.js',
									'../Content/components/_mod/bootstrap-wysiwyg/bootstrap-wysiwyg.js']
							},

							{
								name: 'markdown',
								files: ['../Content/components/markdown/lib/markdown.js', '../Content/components/bootstrap-markdown/js/bootstrap-markdown.js']
							},

							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/wysiwyg.js']
							}
						]);
					}]
				}


			})
			.state('form.dropzone', {
				url: '/dropzone',
				title: 'Dropzone File Upload',

				templateUrl: 'Content/assets/views/pages/dropzone.html',
				controller: 'DropzoneCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								name: 'dropzone',
								serie: true,
								files: ['../Content/components/dropzone/dist/dropzone.js', '../Content/components/angular-dropzone/lib/angular-dropzone.js']
							},

							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/dropzone.js']
							},

							{
								name: 'AceApp',
								insertBefore: '#main-ace-style',
								files: ['../Content/components/dropzone/dist/dropzone.css']
							}
						]);
					}]
				}
			})


			.state('widgets', {
				url: '/widgets',
				title: 'Widgets',
				icon: 'fa fa-list-alt',

				templateUrl: 'Content/assets/views/pages/widgets.html',
				controller: 'WidgetCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								serie: true,
								name: 'sortable',
								files: ['../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.js', '../Content/components/jqueryui-touch-punch/jquery.ui.touch-punch.js']
							},

							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/widgets.js']
							}
						]);
					}]
				}
			})

			.state('calendar', {
				url: '/calendar',
				title: 'Calendar',

				templateUrl: 'Content/assets/views/pages/calendar.html',
				controller: 'CalendarCtrl',

				icon: 'fa fa-calendar',
				badge: '<i class="ace-icon fa fa-exclamation-triangle red bigger-130"></i>',
				'badge-class': 'badge-transparent',
				tooltip: '2&nbsp;Important&nbsp;Events',
				'tooltip-class': 'tooltip-error',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								serie: true,
								name: 'calendar',
								files: ['../Content/components/moment/moment.js', '../Content/components/fullcalendar/dist/fullcalendar.js', '../Content/components/angular-ui-calendar/src/calendar.js']
							},

							{
								serie: true,
								name: 'drag',
								files: ['../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.js', '../Content/components/jqueryui-touch-punch/jquery.ui.touch-punch.js', '../Content/components/angular-dragdrop/src/angular-dragdrop.js']
							},

							{
								name: 'bootbox',
								files: ['../Content/components/bootbox.js/bootbox.js']
							},

							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/calendar.js']
							},

							{
								name: 'AceApp',
								insertBefore: '#main-ace-style',
								files: ['../Content/components/fullcalendar/dist/fullcalendar.css']
							}
						]);
					}]
				}
			})

			.state('gallery', {
				url: '/gallery',
				title: 'Gallery',

				icon: 'fa fa-picture-o',

				templateUrl: 'Content/assets/views/pages/gallery.html',
				controller: 'GalleryCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([
							{
								name: 'gallery',
								files: ['../Content/components/jquery-colorbox/jquery.colorbox.js', '../Content/components/angular-colorbox/js/angular-colorbox.js']
							},

							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/gallery.js']
							},

							{
								name: 'AceApp',
								insertBefore: '#main-ace-style',
								files: ['../Content/components/jquery-colorbox/example1/colorbox.css']
							}
						]);
					}]
				}

			})

			.state('more', {
				'abstract': true,
				//url: '/more',
				title: 'More Pages',
				template: '<ui-view/>',
				icon: 'fa fa-tag'
			})
			.state('more.profile', {
				url: '/profile',
				title: 'User Profile',

				templateUrl: 'Content/assets/views/pages/profile.html',
				controller: 'ProfileCtrl',

				resolve: {
					lazyLoad: ['$ocLazyLoad', function ($ocLazyLoad) {
						return $ocLazyLoad.load([

							{
								name: 'datepicker',
								serie: true,
								files: ['../Content/components/moment/moment.js', '../Content/components/bootstrap-datepicker/dist/js/bootstrap-datepicker.js']
							},

							{
								name: 'spinner',
								files: ['../Content/components/fuelux/js/spinbox.js']
							},

							{
								serie: true,
								name: 'jquery-ui',
								files: ['../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.js', '../Content/components/jqueryui-touch-punch/jquery.ui.touch-punch.js']
							},

							{
								name: 'x-editable',
								serie: true,
								files: ['../Content/components/_mod/x-editable/bootstrap-editable.js', '../Content/components/_mod/x-editable/ace-editable.js']
							},

							{
								name: 'AceApp',
								files: ['../Content/assets/js/controllers/pages/profile.js']
							},

							{
								name: 'AceApp',
								insertBefore: '#main-ace-style',
								files: ['../Content/components/_mod/jquery-ui.custom/jquery-ui.custom.css',
									'../Content/components/bootstrap-datepicker/dist/css/bootstrap-datepicker3.css',
									'../Content/components/_mod/x-editable/bootstrap-editable.css']
							}
						]);
					}]
				}
			})
			.state('more.even', {
				'abstract': true,

				title: 'Even More',
				template: '<ui-view/>'

			})

			.state('more.even.error', {
				url: '/error',
				title: 'Error',
				templateUrl: 'Content/assets/pages/error.html'
			})


		/**
		.state('more.inbox', {
		  url: '/inbox',
		  title: 'Inbox',
  
		  templateUrl: 'Content/assets/pages/inbox.html'
		})
		.state('more.pricing', {
		  url: '/pricing',
		  title: 'Pricing',
  
		  templateUrl: 'Content/assets/pages/pricing.html'
		})
		.state('more.invoice', {
		  url: '/invoice',
		  title: 'Invoice',
  
		  templateUrl: 'Content/assets/pages/invoice.html'
		})
		.state('more.timeline', {
		  url: '/timeline',
		  title: 'Timeline',
  
		  templateUrl: 'Content/assets/pages/timeline.html'
		})
	    
	    
		.state('other', {
		  'abstract': true,
		  title: 'Other Pages',
		  template: '<ui-view/>',
		  icon: 'fa fa-file-o',
		  badge: '5', 
		  'badge-class': 'badge-primary'
		})
		.state('other.faq', {
		  url: '/faq',
		  title: 'FAQ',
  
		  templateUrl: 'Content/assets/pages/faq.html'
		})
		.state('other.error', {
		  url: '/error',
		  title: 'Error',
  
		  templateUrl: 'Content/assets/pages/error.html'
		})
		.state('other.grid', {
		  url: '/grid',
		  title: 'Grid',
  
		  templateUrl: 'Content/assets/pages/grid.html'
		})
		.state('other.blank', {
		  url: '/blank',
		  title: 'Blank',
  
		  templateUrl: 'Content/assets/pages/blank.html'
		})
		*/
	})
	.run(function ($rootScope) {

	});
