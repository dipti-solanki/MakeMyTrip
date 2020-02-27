import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BusAvailabilityDayBase {

//#region busAvailableId Prop
        @prop()
        busAvailableId : number;
//#endregion busAvailableId Prop


//#region availableDay Prop
        @required()
        @maxLength({value:50})
        availableDay : string;
//#endregion availableDay Prop


//#region busDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        busDetailId : number;
//#endregion busDetailId Prop



}