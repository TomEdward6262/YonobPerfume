/**
 * @license Copyright (c) 2003-2019, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';

    config.syntaxhighlight_hideControlls = true;
    config.syntaxhighlight_lang = 'csharp';
    config.language = 'vi';
    config.filebrowserBrowserUrl = '/Assets/Admin/js/plugins/ckfinder/ckfinder.html';
    config.filebrowserImageBrowserUrl = '/Assets/Admin/js/plugins/ckfinder/ckfinder.html?Type=Image';
    config.filebrowserFlashBrowserUrl = '/Assets/Admin/js/plugins/ckfinder/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = '/Assets/Admin/js/plugins/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserFlashUploadUrl = '/Assets/Admin/js/plugins/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
    config.filebrowserImageUploadUrl = '/Data';

    CKFinder.setupCKEditor(null, '/Assets/Admin/js/plugins/ckfinder/');
};
