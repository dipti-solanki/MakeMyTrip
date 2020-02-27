import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class TravellerBase {

//#region travellerId Prop
        @prop()
        travellerId : number;
//#endregion travellerId Prop


//#region appUserId Prop
        @prop()
        appUserId : number;
//#endregion appUserId Prop


//#region firstName Prop
        @required()
        @maxLength({value:50})
        firstName : string;
//#endregion firstName Prop


//#region lastName Prop
        @required()
        @maxLength({value:50})
        lastName : string;
//#endregion lastName Prop


//#region emailId Prop
        @required()
        @maxLength({value:50})
        emailId : string;
//#endregion emailId Prop


//#region mobileNumber Prop
        @required()
        mobileNumber : number;
//#endregion mobileNumber Prop



}