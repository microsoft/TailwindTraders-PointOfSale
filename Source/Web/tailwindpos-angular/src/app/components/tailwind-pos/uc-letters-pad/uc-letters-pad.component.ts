import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tailwind-pos-uc-letters-pad",
   styleUrls : ["./uc-letters-pad.component.css"],
   templateUrl : "./uc-letters-pad.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TailwindPOS.ucLettersPad"])
export class ucLettersPadComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}