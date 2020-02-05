
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as TailwindPOS from './components/tailwind-pos';

@NgModule({
  imports: [
    CommonModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    TailwindPOS.frmGiftCardCodeComponent,
    TailwindPOS.frmPaymentComponent,
    TailwindPOS.ucNumbersPadComponent,
    TailwindPOS.frmSearchCustComponent,
    TailwindPOS.frmCustAddComponent,
    TailwindPOS.ucLettersPadComponent,
    TailwindPOS.frmPauseComponent,
    TailwindPOS.frmCashCountComponent,
    TailwindPOS.frmSalesComponent,
  ],
  declarations: [
    TailwindPOS.frmGiftCardCodeComponent,
    TailwindPOS.frmPaymentComponent,
    TailwindPOS.ucNumbersPadComponent,
    TailwindPOS.frmSearchCustComponent,
    TailwindPOS.frmCustAddComponent,
    TailwindPOS.ucLettersPadComponent,
    TailwindPOS.frmPauseComponent,
    TailwindPOS.frmCashCountComponent,
    TailwindPOS.frmSalesComponent,
  ],
  entryComponents: [
    TailwindPOS.frmGiftCardCodeComponent,
    TailwindPOS.frmPaymentComponent,
    TailwindPOS.ucNumbersPadComponent,
    TailwindPOS.frmSearchCustComponent,
    TailwindPOS.frmCustAddComponent,
    TailwindPOS.ucLettersPadComponent,
    TailwindPOS.frmPauseComponent,
    TailwindPOS.frmCashCountComponent,
    TailwindPOS.frmSalesComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class TailwindPOSModule { }

