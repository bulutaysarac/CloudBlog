(function ($) {
    "use strict";
    
    /*Summernote*/
    if( $('.summernote').length ) {
        $('.summernote').summernote({
            height:1500 ,
            placeholder: 'Hello Bootstrap 4',
        });
    }
    
})(jQuery);