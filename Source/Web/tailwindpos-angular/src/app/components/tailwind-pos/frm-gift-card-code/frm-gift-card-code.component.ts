import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tailwind-pos-frm-gift-card-code",
   styleUrls : ["./frm-gift-card-code.component.css"],
   templateUrl : "./frm-gift-card-code.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTailwindPOS.frmGiftCardCode"])
export class frmGiftCardCodeComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}