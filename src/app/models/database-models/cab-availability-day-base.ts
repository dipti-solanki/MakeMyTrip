import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CabAvailabilityDayBase {

//#region cabAvailableId Prop
        @prop()
        cabAvailableId : number;
//#endregion cabAvailableId Prop


//#region availableDay Prop
        @required()
        @maxLength({value:50})
        availableDay : string;
//#endregion availableDay Prop


//#region cabDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        cabDetailId : number;
//#endregion cabDetailId Prop



}