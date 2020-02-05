import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tailwind-pos-frm-search-cust",
   styleUrls : ["./frm-search-cust.component.css"],
   templateUrl : "./frm-search-cust.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTailwindPOS.frmSearchCust"])
export class frmSearchCustComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}